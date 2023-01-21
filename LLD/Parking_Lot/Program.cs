using Parking_Lot.Models;
using Parking_Lot.ParkingLotStrategy;

namespace Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ParkingLotService parkingLotService = new ParkingLotService();
            
            List<Floor> floors = new List<Floor>();
            floors[0].AddSlot(new Slot(3, VehicleType.CAR));
            floors[0].AddSlot(new Slot(4, VehicleType.CAR));
            floors[0].AddSlot(new Slot(1, VehicleType.TRUCK));
            floors[0].AddSlot(new Slot(5, VehicleType.BIKE));
            floors[0].AddSlot(new Slot(7, VehicleType.BIKE));
            floors[1].AddSlot(new Slot(3, VehicleType.BIKE));
            floors[1].AddSlot(new Slot(5, VehicleType.BIKE));
            floors[2].AddSlot(new Slot(2, VehicleType.CAR));

            var parkingLot = parkingLotService.CreateParkingLot("PR123", floors);


            
            
        }
        
    }
}