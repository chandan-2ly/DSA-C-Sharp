using Parking_Lot.Models;

namespace Parking_Lot
{

    public class FloorService
    {
        private readonly SlotAllocationService _slotAllocationService;

        public FloorService()
        {
            _slotAllocationService = new SlotAllocationService();
        }

        public Floor CreateFloors(string parkingLotId, int floorCount, int slotsPerFloorCount)
        {
            for (int i = 1; i <= floorCount; i++)
            {
                var floor = new Floor(i, new List<Slot>());
                var slot = _slotAllocationService.CreateSlot(slotsPerFloorCount);
                floor.Slots.Add(floor);
            }
        }
        public void CreateSlot(int slotCount)
        {
            for (int i = 1; i <= slotCount; i++)
            {
                if (i == 1)
                    Slots.Add(new Slot(i, VehicleType.TRUCK));
                else if (i == 2 || i == 3)
                    Slots.Add(new Slot(i, VehicleType.BIKE));
                else
                    Slots.Add(new Slot(i, VehicleType.CAR));
            }
        }

        public void FreeSlots(List<Floor> floors, VehicleType vehicleType)
        {
            foreach (var floor in floors)
            {
                var freeSlots = floor.Slots.Where(x => x.IsAvailableToPark && x.VehicleType == vehicleType).Select(y => y.Id.ToString()).ToArray();
                Console.WriteLine($"Free slots for TRUCK on Floor {floor.Id}: {string.Join(",", freeSlots)}");
            }
        }

        public void FreeSlotsCount(List<Floor> floors, VehicleType vehicleType)
        {
            foreach (var floor in floors)
            {
                var freeSlotCount = floor.Slots.Count(x => x.IsAvailableToPark && x.VehicleType == vehicleType);
                Console.WriteLine($"No. of free slots for CAR on Floor {floor.Id}: {freeSlotCount}");
            }
        }

        public void OccupiedSlots(List<Floor> floors, VehicleType vehicleType)
        {
            foreach (var floor in floors)
            {
                var freeSlots = floor.Slots.Where(x => !x.IsAvailableToPark && x.VehicleType == vehicleType).Select(y => y.Id.ToString()).ToArray();
                Console.WriteLine($"Free slots for TRUCK on Floor {floor.Id}: {string.Join(",", freeSlots)}");
            }
        }
    }
}