using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class VehicleRentalSystem
    {
        private List<User> _users;
        private List<Store> _stores;

        public VehicleRentalSystem(List<User> users, List<Store> stores)
        {
            _users = users;
            _stores = stores;
        }

        public Store GetLocationBasedStore(Location location)
        {
            return _stores.FirstOrDefault(x => x.Location.id == location.id);
        }
    }
}
