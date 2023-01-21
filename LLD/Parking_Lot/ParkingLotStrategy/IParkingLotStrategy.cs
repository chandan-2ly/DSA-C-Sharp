namespace Parking_Lot.ParkingLotStrategy
{
    public interface IParkingLotStrategy
    {
        public void Add(int num);
        public void Remove(int num);
        public int GetNext();
    }
}
