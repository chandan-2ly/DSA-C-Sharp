namespace Parking_Lot
{
    public class SlotAllocationService
    {
        private readonly FloorService _floorService;

        public SlotAllocationService()
        {
            _floorService = new FloorService();
        }

        public (int, int, int) GetFreeSlot()
        {
            int freeParkingLot = -1;
            int freeParkingFloor = -1;
            int freeParkingSlot = -1;


        }

        internal Ticket AllocateParkingSlot(List<ParkingLot> parkingLots, VehicleType vehicleType, string vehicleRegNo, string color)
        {
            throw new NotImplementedException();
        }
    }
}