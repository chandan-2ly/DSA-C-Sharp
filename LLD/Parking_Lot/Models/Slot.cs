namespace Parking_Lot.Models
{
    public class Slot
    {
        public int Id { get; }
        public VehicleType VehicleType { get; }
        public bool IsAvailableToPark { get; private set; }

        public Vehicle? ParkedVehicle { get; private set; }

        public Slot(int id, VehicleType vehicleType)
        {
            Id = id;
            VehicleType = vehicleType;
            IsAvailableToPark = true;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            if (VehicleType != vehicle.VehicleType)
            {
                throw new Exception("Vehicle type dint match");
            }
            ParkedVehicle = vehicle;
            IsAvailableToPark = false;
        }

        //public Vehicle? GetParkedVehicle()
        //{
        //    return ParkedVehicle;
        //}

        public void ReleaseSlot()
        {
            ParkedVehicle = null;
            IsAvailableToPark = true;
        }
    }
}