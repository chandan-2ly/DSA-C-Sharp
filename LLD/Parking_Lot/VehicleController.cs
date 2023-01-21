namespace Parking_Lot
{
    public class VehicleController
    {
        public List<Vehicle> Vehicles { get; }

        public VehicleController()
        {
            Vehicles = new List<Vehicle>();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
}