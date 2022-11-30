namespace WithStrategyDesignPattern
{
    internal class PassengerVehicle : Vehicle
    {
        public PassengerVehicle() : base(new NormalDriveStrategy()) { }
    }
}
