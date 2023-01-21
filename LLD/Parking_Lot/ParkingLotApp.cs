using Parking_Lot.ParkingLotStrategy;
using System.Collections.Generic;

namespace Parking_Lot
{
    public class ParkingLotApp
    {
        public ParkingLotService _parkingLotService;
        public VehicleController _vehicleController;

        public ParkingLotApp()
        {
            _parkingLotService = new ParkingLotService();
            _vehicleController = new VehicleController();
        }

        public void CreateParkingLot(string parkingLotId, int floorCount, int slotsPerFloorCount, IParkingLotStrategy parkingLotStrategy)
        {
            

            var parkingLot = _parkingLotService.CreateParkingLot(parkingLotId, floorCount, slotsPerFloorCount, parkingLotStrategy);
            //var parkingLot = _parkingLotController.GetParkingLot("PR1234");

            #region display
            var vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.CAR);
            vehicleTypeDisplay.FreeSlotsCount(parkingLot.Floors);

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.BIKE);
            vehicleTypeDisplay.FreeSlotsCount(parkingLot?.Floors);

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.TRUCK);
            vehicleTypeDisplay.FreeSlotsCount(parkingLot?.Floors);

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.CAR);
            vehicleTypeDisplay.FreeSlots(parkingLot?.Floors);
            

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.BIKE);
            freeSlots = vehicleTypeDisplay.FreeSlots(parkingLot?.Floors);
            foreach (var display in freeSlots)
            {
                Console.WriteLine($"Free slots for BIKE on Floor {display.Key}: {string.Join(",", display.Value.Select(n => n.ToString()).ToArray())}");
            }

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.TRUCK);
            freeSlots = vehicleTypeDisplay.FreeSlots(parkingLot?.Floors);
            foreach (var display in freeSlots)
            {
                Console.WriteLine($"Free slots for TRUCK on Floor {display.Key}: {string.Join(",", display.Value.Select(n => n.ToString()).ToArray())}");
            }

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.CAR);
            var freeSlots = vehicleTypeDisplay.FreeSlots(parkingLot?.Floors);
            foreach (var display in freeSlots)
            {
                Console.WriteLine($"Free slots for CAR on Floor {display.Key}: {string.Join(",", display.Value.Select(n => n.ToString()).ToArray())}");
            }

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.BIKE);
            freeSlots = vehicleTypeDisplay.FreeSlots(parkingLot?.Floors);
            foreach (var display in freeSlots)
            {
                Console.WriteLine($"Free slots for BIKE on Floor {display.Key}: {string.Join(",", display.Value.Select(n => n.ToString()).ToArray())}");
            }

            vehicleTypeDisplay = VehicleTypeDisplayFactory.GetVehicleTypeDisplay(VehicleType.TRUCK);
            freeSlots = vehicleTypeDisplay.FreeSlots(parkingLot?.Floors);
            foreach (var display in freeSlots)
            {
                Console.WriteLine($"Free slots for TRUCK on Floor {display.Key}: {string.Join(",", display.Value.Select(n => n.ToString()).ToArray())}");
            }
            #endregion

            //var floorCount = _parkingLotController.GetParkingLot().GetFloorCount();
            //for(int i = 0; i < floorCount; i++)
            //{
            //    Console.WriteLine($"No. of free slots for CAR on Floor 1: 3");
            //}

            
        }
        public void Demo()
        {
            #region Vehicles
            var v1 = new Vehicle(1, "RG100", "Red", "Suzuki", VehicleType.CAR);
            _vehicleController.AddVehicle(v1);
            var v2 = new Vehicle(2, "RG105", "Black", "Honda", VehicleType.CAR);
            _vehicleController.AddVehicle(v2);
            var v3 = new Vehicle(3, "RG601", "White", "BMW", VehicleType.BIKE);
            _vehicleController.AddVehicle(v3);
            var v4 = new Vehicle(4, "RG802", "Blue", "Audi", VehicleType.TRUCK);
            _vehicleController.AddVehicle(v4);
            var v5 = new Vehicle(5, "RG609", "Navy", "Pulser", VehicleType.BIKE);
            _vehicleController.AddVehicle(v5);
            #endregion

            #region Display
            //Display free slot count CAR
            //Display free slot count Bike
            //Display free slot count Truck
            //display free slots CAR
            //display free slots Bike
            //Display free slots Truck
            //Display occupied slot car
            //Display occupied slot Bike
            //Display occupied slot Truck
            //park vehicle car black
            //park vehicle car red
            //Display free slot count Car
            //display free slot count Bike
            //unpark vehicle with ticket id
            //unpark vehicle with ticket
            //Display free slot count CAR
            //Display free slot count Bike
            //Display free slot count Truck
            //display free slots CAR
            //display free slots Bike
            //Display free slots Truck
            //Display occupied slot car
            //Display occupied slot Bike
            //Display occupied slot Truck
            //park vehicle bike
            //park vehicle truck
            //park vehicle truck
            //Display free slot count CAR
            //Display free slot count Bike
            //Display free slot count Truck
            //display free slots CAR
            //display free slots Bike
            //Display free slots Truck
            //Display occupied slot car
            //Display occupied slot Bike
            //Display occupied slot Truck
            //exit
            #endregion

            var ticket = _parkingLotService.ParkVehicle(v2.VehicleType, v2.RegNo, v2.Color);
        }
    }
}
