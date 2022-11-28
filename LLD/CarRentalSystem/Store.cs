using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Store
    {
        public int StoreId { get; set; }
        private VehicleInventoryManagement _vehicleInventory;
        public Location Location { get; set; }
        public List<Reservation> _reservations;

        public Store(int storeId, Location location)
        {
            StoreId = storeId;
            _vehicleInventory = new VehicleInventoryManagement();
            Location = location;
            _reservations = new List<Reservation>();
        }

        public void AddVehiclesToInventory(List<Vehicle> vehicles)
        {
            _vehicleInventory.AddVehicles(vehicles);
        }

        internal List<Vehicle> GetVehicles()
        {
            return _vehicleInventory.GetVehicles();
        }
        internal List<Vehicle> GetVehicles(VehicleType type)
        {
            return _vehicleInventory.GetVehicles().FindAll(x => x.Type == type);
        }

        internal Reservation CreateReservation(Vehicle vehicle, User user)
        {
            Reservation reservation = new Reservation();
            reservation.CreateReserve(user, vehicle);

            _reservations.Add(reservation);
            return reservation;
        }

        internal void CompleteReservation(int reservationId)
        {
            _reservations.FirstOrDefault(x => x.reservationId == reservationId).Status = ReservationStatus.COMPLETED;
        }
    }
}
