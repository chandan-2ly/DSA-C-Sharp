using CabBooking.Exceptions;
using CabBooking.Models;
using CabBooking.RepositoryLayer;

namespace CabBooking.Service
{
    public class CabService : ICabService
    {
        private readonly ICabRepository _cabRepository;

        public CabService(ICabRepository cabRepository)
        {
            _cabRepository = cabRepository ?? throw new ArgumentNullException(nameof(cabRepository));
        }

        public List<Cab> GetAllRegisteredCabs()
        {
            return _cabRepository.GetAllCabs();
        }

        public Cab GetCab(int id)
        {
            return _cabRepository.GetCab(id);
        }

        public List<Cab> GetCabs(Location fromPoint, double distance)
        {
            List<Cab> result = new List<Cab>();
            var cabs = _cabRepository.GetAllCabs();
            if(cabs != null && cabs.Count > 0)
            {
                foreach(Cab cab in cabs)
                {
                    if(cab.IsAvailable && cab.CurrentLocation.Distance(fromPoint) <= distance)
                    {
                        result.Add(cab);
                    }
                }
            }
            else
            {
                throw new CabNotFoundException("No any cab exist");
            }
            return result;
        }

        public void RegisterCab(Cab cabDetails)
        {
            _cabRepository.RegisterCab(cabDetails);
        }

        public void UpdateAvailability(int cabId, bool availability)
        {
            _cabRepository.UpdateAvailability(cabId, availability);
        }

        public void UpdateLocation(int cabId, Location location)
        {
            _cabRepository.UpdateLocation(cabId, location);
        }

        public void UpdateStatus(int cabId, CabStatus status)
        {
            _cabRepository.UpdateStatus(cabId, status);
        }
    }
}
