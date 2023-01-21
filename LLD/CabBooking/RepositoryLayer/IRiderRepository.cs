using CabBooking.Models;

namespace CabBooking.RepositoryLayer
{
    public interface IRiderRepository
    {
        public void RegisterRider(Rider rider);
        public Rider GetRider(int id);
    }
}
