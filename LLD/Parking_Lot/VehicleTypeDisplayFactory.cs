namespace Parking_Lot
{
    public class VehicleTypeDisplayFactory
    {
        public static IVehicleTypeDisplay GetVehicleTypeDisplay(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.CAR:
                    return new CarVehicleTypeDispaly();
                case VehicleType.TRUCK:
                    return new TruckVehicleTypeDispaly();
                case VehicleType.BIKE:
                    return new BikeVehicleTypeDispaly();
            }

            return null;
        }
    }
}
