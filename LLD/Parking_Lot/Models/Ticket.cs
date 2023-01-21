namespace Parking_Lot.Models
{
    public class Ticket
    {
        public int TicketId { get; }
        public DateTime EntryTime { get; }
        public Vehicle Vehicle { get; }
        public int SlotId { get; }
        public int FloorId { get; }
        public string ParkingLotId { get; }
        public DateTime? ExitTime { get; }
        public double? Price { get; }

        public Ticket(int ticketId, DateTime entryTime, Vehicle vehicle, int slotId, 
            int floorId, string parkingLotId, DateTime? exitTime, double? price)
        {
            TicketId = ticketId;
            EntryTime = entryTime;
            Vehicle = vehicle;
            SlotId = slotId;
            FloorId = floorId;
            ParkingLotId = parkingLotId;
            ExitTime = exitTime;
            Price = price;
        }
    }
}