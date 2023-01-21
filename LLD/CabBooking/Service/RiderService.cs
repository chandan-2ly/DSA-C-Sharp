using CabBooking.Models;
using CabBooking.RepositoryLayer;

namespace CabBooking.Service
{
    public class RiderService : IRiderService
    {
        private readonly IRiderRepository _riderRepository;

        public RiderService(IRiderRepository riderRepository)
        {
            _riderRepository = riderRepository;
        }

        public Rider GetRider(int id)
        {
            return _riderRepository.GetRider(id);
        }

        public void RegisterRider(Rider rider)
        {
            _riderRepository.RegisterRider(rider);
        }
    }
}
