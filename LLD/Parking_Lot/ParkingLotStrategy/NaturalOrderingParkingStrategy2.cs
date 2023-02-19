using Parking_Lot.Models;

namespace Parking_Lot.ParkingLotStrategy
{
    internal class NaturalOrderingParkingStrategy2 : IParkingLotStrategy
    {
        PriorityQueue<Floor, int> queue;
            

        public NaturalOrderingParkingStrategy2()
        {
            queue = new PriorityQueue<Floor, int>(Comparer<int>.Create((x, y) => x - y));
        }

        public void AddFloor(Floor floor)
        {
            queue.Enqueue(floor, floor.Id);
        }

        public Slot GetFreeSlot(VehicleType vehicleType)
        {
            while(queue.Count > 0)
            {
                var floor = queue.Dequeue();
                var freeSlot = floor.Slots.Where(x => x.IsAvailableToPark && x.VehicleType == vehicleType)
                    .OrderBy(y => y.Id)
                    .FirstOrDefault();
            }
        }

    }
}
