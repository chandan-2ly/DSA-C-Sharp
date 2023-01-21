using CabBooking.Models;

namespace CabBooking.Service
{
    public interface ITripService
    {
        void CreateTrip(Rider rider, Location srcLocation, Location destLocation);
        void EndTrip(int cabId);
        List<Trip> TripHistory(Rider rider);
    }
}