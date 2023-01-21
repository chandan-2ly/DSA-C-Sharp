using CabBooking.Exceptions;
using CabBooking.Models;
using CabBooking.RepositoryLayer;
using CabBooking.Strategies;

namespace CabBooking.Service
{
    public class TripService : ITripService
    {
        public static readonly double MAX_ALLOWED_TRIP_MATCHING_DISTANCE = 10.0;
        private readonly ICabService _cabService;
        private readonly IRiderService _riderService;
        private readonly ITripRepository _tripRepository;
        private readonly ICabMatchingStrategy _matchingStrategy;
        private readonly IPricingStrategy _pricingStrategy;
        public TripService(ICabService cabService, IRiderService riderService, ITripRepository tripRepository, 
            ICabMatchingStrategy matchingStrategy, IPricingStrategy pricingStrategy)
        {
            _cabService = cabService;
            _riderService = riderService;
            _tripRepository = tripRepository;
            _matchingStrategy = matchingStrategy;
            _pricingStrategy = pricingStrategy;
        }

        public void CreateTrip(Rider rider, Location srcLocation, Location destLocation)
        {
            List<Cab> nearByCabs = _cabService.GetCabs(srcLocation, MAX_ALLOWED_TRIP_MATCHING_DISTANCE);
            Cab? selectedCab = _matchingStrategy.MatchCabToRider(rider, nearByCabs, srcLocation, destLocation);
            
            if(selectedCab == null)
            {
                throw new CabNotFoundException("No cabs available");
            }

            double fare = _pricingStrategy.FindPrice(srcLocation, destLocation);

            Trip trip = _tripRepository.CreateTrip(rider, selectedCab, fare, srcLocation, destLocation);

            selectedCab.UpdateStatus(CabStatus.RUNNING);
            selectedCab.UpdateCurrentTrip(trip);
            selectedCab.UpdateAvailability(false);

        }

        public void EndTrip(int cabId)
        {
            var cab = _cabService.GetCab(cabId);
            if(cab == null)
            {
                throw new CabNotFoundException("Cab does not exist");
            }
            if(cab.CurrentTrip == null)
            {
                throw new TripNotFoundException("No trip is associated for this cab");
            }
            cab.CurrentTrip.EndTrip();

            cab.UpdateCurrentTrip(null);
            cab.UpdateStatus(CabStatus.AVAIALBLE);
            cab.UpdateAvailability(true);

        }

        public List<Trip> TripHistory(Rider rider)
        {
            return _tripRepository.TripHistory(rider);
        }
    }
}
