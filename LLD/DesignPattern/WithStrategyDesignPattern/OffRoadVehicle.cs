namespace WithStrategyDesignPattern
{
    internal class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new StuntDriveStrategy()) { }
    }
}
