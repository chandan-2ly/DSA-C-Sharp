namespace Parking_Lot
{
    public class TruckVehicleTypeDispaly : IVehicleTypeDisplay
    {
        public void FreeSlots(List<Floor> floors)
        {
            foreach (var floor in floors)
            {
                var freeSlots = floor.Slots.Where(x => x.IsAvailableToPark && x.VehicleType == VehicleType.TRUCK).Select(y => y.Id.ToString()).ToArray();
                Console.WriteLine($"Free slots for TRUCK on Floor {floor.Id}: {string.Join(",", freeSlots)}");
            }
        }

        public void FreeSlotsCount(List<Floor> floors)
        {
            foreach (var floor in floors)
            {
                var freeSlotCount = floor.Slots.Count(x => x.IsAvailableToPark && x.VehicleType == VehicleType.TRUCK);
                Console.WriteLine($"No. of free slots for CAR on Floor {floor.Id}: {freeSlotCount}");
            }
        }

        public void OccupiedSlots(List<Floor> floors)
        {
            foreach (var floor in floors)
            {
                var freeSlots = floor.Slots.Where(x => !x.IsAvailableToPark && x.VehicleType == VehicleType.TRUCK).Select(y => y.Id.ToString()).ToArray();
                Console.WriteLine($"Free slots for TRUCK on Floor {floor.Id}: {string.Join(",", freeSlots)}");
            }
        }
    }
}
