using CabBooking.Exceptions;
using CabBooking.Models;

namespace CabBooking.RepositoryLayer
{
    public class HashMapBasedRiderStorage : IRiderRepository
    {
        Dictionary<int, Rider> _map;

        public HashMapBasedRiderStorage()
        {
            _map = new Dictionary<int, Rider>();
        }

        public Rider GetRider(int id)
        {
            if (!_map.ContainsKey(id))
            {
                throw new RiderNotFoundException("Rider does not exist");
            }
            return _map[id];
        }

        public void RegisterRider(Rider rider)
        {
            if (_map.ContainsKey(rider.Id))
            {
                throw new RiderAlreadyExistException("RIder already exist");
            }
            _map.Add(rider.Id, rider);
        }
    }
}
