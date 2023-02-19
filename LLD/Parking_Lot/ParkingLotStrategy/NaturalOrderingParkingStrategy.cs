using Parking_Lot.Models;

namespace Parking_Lot.ParkingLotStrategy
{
    internal class NaturalOrderingParkingStrategy : IParkingLotStrategy
    {
        PriorityQueue<Floor, int> _floorHeap;
        //PriorityQueue<Slot, int> _slotHeap;
        Dictionary<int, Dictionary<VehicleType, PriorityQueue<Slot, int>>> _vehicleTypeFloorSlotMap; 
            

        public NaturalOrderingParkingStrategy()
        {
            _floorHeap = new PriorityQueue<Floor, int>(Comparer<int>.Create((x, y) => x - y));
            //_slotHeap = new PriorityQueue<Slot, int>(Comparer<int>.Create((x, y) => x - y));
            _vehicleTypeFloorSlotMap = new Dictionary<int, Dictionary<VehicleType, PriorityQueue<Slot, int>>>();
        }

        public void AddFloor(Floor floor)
        {
            _floorHeap.Enqueue(floor, floor.Id);
            foreach(var slot in floor.Slots)
            {
                AddSlot(floor.Id, slot);
            }
        }

        public void AddSlot(int floorId, Slot slot)
        {
            if (!_vehicleTypeFloorSlotMap.ContainsKey(floorId))
            {
                throw new Exception("Floor does not exist");
            }
            _vehicleTypeFloorSlotMap[floorId][slot.VehicleType].Enqueue(slot, slot.Id);
        }

        public void RemoveSlot(int floorId, VehicleType vehicleType)
        {
            _vehicleTypeFloorSlotMap[floorId][vehicleType].Dequeue();
        }

        public Slot GetFreeSlot(VehicleType vehicleType)
        {
            var vehicleTypeMap = _vehicleTypeFloorSlotMap.Values.Where(x => x.ContainsKey(vehicleType)).FirstOrDefault();
            var slot = vehicleTypeMap[vehicleType].Dequeue();
            return slot;
        }

    }
}
