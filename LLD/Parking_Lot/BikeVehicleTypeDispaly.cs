namespace Parking_Lot
{
    public class BikeVehicleTypeDispaly : IVehicleTypeDisplay
    {
        public void FreeSlots(List<Floor> floors)
        {
            throw new NotImplementedException();
        }

        public void FreeSlotsCount(List<Floor> floors)
        {
            foreach (var floor in floors)
            {
                var freeSlotCount = floor.Slots.Count(x => x.IsAvailableToPark && x.VehicleType == VehicleType.BIKE);
                Console.WriteLine($"No. of free slots for CAR on Floor {floor.Id}: {freeSlotCount}");
            }
        }

        public bool IsAvailable(VehicleType vehicleType)
        {
            if (vehicleType == VehicleType.BIKE)
                return true;
            return false;
        }

        public void OccupiedSlots(List<Floor> floors)
        {
            throw new NotImplementedException();
        }
    }
}
