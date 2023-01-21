using CabBooking.Exceptions;
using CabBooking.Models;

namespace CabBooking.RepositoryLayer
{
    public class HashMapBasedCabStorgae : ICabRepository
    {
        private Dictionary<int, Cab> _map;

        public HashMapBasedCabStorgae()
        {
            _map = new Dictionary<int, Cab>();
        }

        public Cab GetCab(int id)
        {
            if (!_map.ContainsKey(id))
            {
                throw new CabNotFoundException("Cab does not exist");
            }
            return _map[id];
        }

        public List<Cab> GetAllCabs()
        {
            return _map.Values.ToList();
        }

        public void RegisterCab(Cab cabDetails)
        {
            if (_map.ContainsKey(cabDetails.Id))
            {
                throw new CabAlreadyExistException("Cab already exist");
            }
            _map.Add(cabDetails.Id, cabDetails);
        }

        public void UpdateAvailability(int cabId, bool availability)
        {
            var cab = GetCab(cabId);
            cab.UpdateAvailability(availability);
        }

        public void UpdateLocation(int cabId, Location location)
        {
            var cab = GetCab(cabId);
            cab.UpdateLocation(location);
        }

        public void UpdateStatus(int cabId, CabStatus status)
        {
            var cab = GetCab(cabId);
            cab.UpdateStatus(status);
        }
    }
}
