using CabBooking.Models;

namespace CabBooking.RepositoryLayer
{
    public interface ITripRepository
    {
        Trip CreateTrip(Rider rider, Cab selectedCab, double fare, Location srcLocation, Location destLocation);
        public List<Trip> TripHistory(Rider rider);
    }
}
