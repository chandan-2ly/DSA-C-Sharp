using CabBooking.Models;

namespace CabBooking.Strategies
{
    public class DefaultCabMatchingStrategy : ICabMatchingStrategy
    {
        public Cab? MatchCabToRider(Rider rider, List<Cab> cabs, Location fromLocation, Location toLocation)
        {
            return cabs.FirstOrDefault(x => x.IsAvailable && x.CabStatus == CabStatus.AVAIALBLE && x.CurrentTrip == null);
        }
    }
}
