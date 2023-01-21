namespace Parking_Lot.Models
{
    public class Vehicle
    {
        public int Id { get; }
        public string RegNo { get; }
        public string Color { get; }
        public string Name { get; }
        public VehicleType VehicleType { get; }

        public Vehicle(int id, string regNo, string color, string name, VehicleType vehicleType)
        {
            Id = id;
            RegNo = regNo;
            Color = color;
            Name = name;
            VehicleType = vehicleType;
        }
    }
}