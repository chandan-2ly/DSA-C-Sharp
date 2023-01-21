using Parking_Lot.ParkingLotStrategy;

namespace Parking_Lot
{
    public class ParkingLotService
    {
        List<ParkingLot> ParkingLots { get; }
        //public FloorService _floorService;
        //private SlotAllocationService _slotAllocationService;
        private TicketService _ticketService;
        private IParkingLotStrategy _parkingLotStrategy;

        public ParkingLotService()
        {
            ParkingLots = new List<ParkingLot>();
            //_floorService = new FloorService();
            //_slotAllocationService = new SlotAllocationService();
            _ticketService = new TicketService();
        }

        //public ParkingLotService(TicketService ticketService, IParkingLotStrategy parkingLotStrategy)
        //{
        //    ParkingLots = new List<ParkingLot>();
        //    _ticketService = ticketService;
        //    _parkingLotStrategy = parkingLotStrategy;
        //}

        public ParkingLot CreateParkingLot(string parkingLotId, List<Floor> floors)
        {
            return new ParkingLot(parkingLotId, floors);
        }

        public Ticket ParkVehicle(Vehicle vehicle)
        {
            if (ParkingLots == null || ParkingLots.Count == 0)
            {
                throw new Exception("There are no parking lot created, plz create it first");
            }

            foreach(var parkingLot in ParkingLots)
            {
                foreach(var floor in parkingLot.Floors)
                {
                    if (floor.Slots.ContainsKey(vehicle.VehicleType))
                    {

                    }
                }
            }

            Ticket ticket = _slotAllocationService.AllocateParkingSlot(parkingLots, vehicleType, vehicleRegNo, color);
            return ticket;
        }

        public void DisplayFreeSlotCount(VehicleType vehicleType)
        {

        }

        public void DisplayFreeSlots(VehicleType vehicleType)
        {

        }

        public void CreateFloors(string parkingId, int floorCount, int slotsPerFloorCount)
        {
            
        }

        public int GetFloorCount()
        {
            return Floors.Count;
        }
    }
}
