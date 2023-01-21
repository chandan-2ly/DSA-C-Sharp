using Parking_Lot.Models;

namespace Parking_Lot
{
    public class CarVehicleTypeDispaly : IVehicleTypeDisplay
    {
        public void FreeSlots(List<Floor> floors)
        {
            throw new NotImplementedException();
        }

        public void OccupiedSlots(List<Floor> floors)
        {
            throw new NotImplementedException();
        }

        public void FreeSlotsCount(List<Floor> floors)
        {
            foreach (var floor in floors)
            {
                var freeSlotCount = floor.Slots.Count(x => x.IsAvailableToPark && x.VehicleType == VehicleType.CAR);
                Console.WriteLine($"No. of free slots for CAR on Floor {floor.Id}: {freeSlotCount}");
            }
        }
    }
}
