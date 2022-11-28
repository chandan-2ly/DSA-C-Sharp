using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Vehicle
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string VehicleNumber { get; private set; }
        public VehicleType Type { get; private set; }
        public VehicleStatus Status { get; private set; }
        public int DailyRentalCost { get; private set; }
        public int HourlyRentalCost { get; private set; }

        public Vehicle(int id, string name, string vehicleNumber, VehicleType type, VehicleStatus status, int dailyRentalCost, int hourlyRentalCost)
        {
            Id = id;
            Name = name;
            VehicleNumber = vehicleNumber;
            Type = type;
            Status = status;
            DailyRentalCost = dailyRentalCost;
            HourlyRentalCost = hourlyRentalCost;
        }
    }
}
