namespace WithStrategyDesignPattern
{
    internal class SportVehicle : Vehicle
    {
        public SportVehicle() : base(new StuntDriveStrategy()) { }
    }
}
