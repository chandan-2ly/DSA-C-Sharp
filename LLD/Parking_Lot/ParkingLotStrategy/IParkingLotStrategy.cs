using Parking_Lot.Models;

namespace Parking_Lot.ParkingLotStrategy
{
    public interface IParkingLotStrategy
    {
        public void AddFloor(Floor floor);
        //public void Remove(int num);
        public Slot GetFreeSlot(VehicleType vehicleType);
    }
}
