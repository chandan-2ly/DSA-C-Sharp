using CabBooking.Models;

namespace CabBooking.Service
{
    public interface IRiderService
    {
        public void RegisterRider(Rider rider);
        public Rider GetRider(int id);
    }
}
