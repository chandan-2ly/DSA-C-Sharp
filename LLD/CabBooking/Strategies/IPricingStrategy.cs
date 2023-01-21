using CabBooking.Models;

namespace CabBooking.Strategies
{
    public interface IPricingStrategy
    {
        double FindPrice(Location fromLocation, Location toLocation);
    }
}
