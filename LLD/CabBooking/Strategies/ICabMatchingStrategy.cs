using CabBooking.Models;

namespace CabBooking.Strategies
{
    public interface ICabMatchingStrategy
    {
        Cab? MatchCabToRider(Rider rider, List<Cab> cabs, Location fromLocation, Location toLocation);
    }
}
