using CabBooking.Exceptions;
using CabBooking.Models;

namespace CabBooking.RepositoryLayer
{
    public class TripRepository : ITripRepository
    {
        private Dictionary<int, List<Trip>> _trips = new Dictionary<int, List<Trip>>();

        public Trip CreateTrip(Rider rider, Cab selectedCab, double fare, Location srcLocation, Location destLocation)
        {
            var trip = new Trip(rider.Id + 1, rider, selectedCab, fare, srcLocation, destLocation);
            if (_trips.ContainsKey(rider.Id))
            {
                _trips[rider.Id].Add(trip);
            }
            else
            {
                _trips.Add(rider.Id, new List<Trip>());
                _trips[rider.Id].Add(trip);
            }

            return trip;
        }

        public List<Trip> TripHistory(Rider rider)
        {
            if (!_trips.ContainsKey(rider.Id))
            {
                throw new TripNotFoundException("No Trips found for this user id");
            }
            return _trips[rider.Id];
        }
    }
}
