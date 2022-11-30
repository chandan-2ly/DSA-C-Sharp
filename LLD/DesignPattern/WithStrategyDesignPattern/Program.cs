namespace WithStrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new PassengerVehicle();
            vehicle.Drive();
            Vehicle vehicle1 = new OffRoadVehicle();
            vehicle1.Drive();
        }
    }
}