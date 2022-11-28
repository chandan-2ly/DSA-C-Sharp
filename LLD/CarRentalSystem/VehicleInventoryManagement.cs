namespace CarRentalSystem
{
    public class VehicleInventoryManagement
    {
        public List<Vehicle> Vehicles { get; }
        public VehicleInventoryManagement()
        {
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void AddVehicles(List<Vehicle> vehicles)
        {
            Vehicles.AddRange(vehicles);
        }

        internal List<Vehicle> GetVehicles()
        {
            return Vehicles;
        }
    }
}