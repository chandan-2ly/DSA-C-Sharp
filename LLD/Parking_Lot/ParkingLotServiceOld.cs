using Parking_Lot.Models;

namespace Parking_Lot
{
    public class ParkingLotServiceOld
    {
        private SlotAllocationService _slotAllocationService;
        private TicketService _ticketService;
        private readonly ParkingLotService _parkingLotController;

        public ParkingLotServiceOld()
        {
            _slotAllocationService = new SlotAllocationService();
            _ticketService = new TicketService();
            _parkingLotController = new ParkingLotService();
        }

        public Ticket ParkVehicle(VehicleType vehicleType, string vehicleRegNo, string color)
        {
            List<ParkingLot> parkingLots = _parkingLotController.GetAllParkingLots();
            if(parkingLots == null || parkingLots.Count == 0)
            {
                throw new Exception("There are no parking lot created, plz create it first");
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

    }
}
