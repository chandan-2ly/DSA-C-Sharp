namespace Parking_Lot
{
    public interface IVehicleTypeDisplay
    {
        public void FreeSlotsCount(List<Floor> floors);
        public void FreeSlots(List<Floor> floors);
        public void OccupiedSlots(List<Floor> floors);
        public bool IsAvailable(VehicleType vehicleType);
    }
}
