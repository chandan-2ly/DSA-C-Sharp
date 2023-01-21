using CabBooking.Models;

namespace CabBooking.Strategies
{
    public class DefaultPricingStrategy : IPricingStrategy
    {
        private const double PER_KM_RATE = 10.0;
        public double FindPrice(Location fromLocation, Location toLocation)
        {
            return fromLocation.Distance(toLocation) * PER_KM_RATE;
        }
    }
}
