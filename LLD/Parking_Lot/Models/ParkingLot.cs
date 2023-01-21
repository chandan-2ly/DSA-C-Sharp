namespace Parking_Lot.Models
{
    public class ParkingLot
    {
        public string Id { get; set; }
        public List<Floor> Floors { get; set; }

        public ParkingLot(string id, List<Floor> floors)
        {
            Id = id;
            Floors = floors;
        }

        //public void CreateFloors(int floorSize, int slotSize)
        //{
        //    for (int i = 1; i <= floorSize; i++)
        //    {
        //        var newFloor = new Floor(i, new Dictionary<VehicleType, Dictionary<int, Slot>>());
        //        newFloor.CreateSlots(slotSize);
        //        Floors.Add(newFloor);

        //    }
        //}

        public void AddFloor(Floor floor)
        {
            Floors.Add(floor);
        }

        public void RemoveFloor(int floorId)
        {
            Floors.Remove(Floors.First(x => x.Id == floorId));
        }
    }
}
