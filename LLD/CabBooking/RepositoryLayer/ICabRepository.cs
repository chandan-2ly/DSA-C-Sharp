using CabBooking.Models;

namespace CabBooking.RepositoryLayer
{
    public interface ICabRepository
    {
        public void RegisterCab(Cab cabDetails);
        public void UpdateLocation(int cabId, Location location);
        public void UpdateStatus(int cabId, CabStatus status);
        public void UpdateAvailability(int cabId, bool availability);
        public Cab GetCab(int id);
        public List<Cab> GetAllCabs();
    }
}
