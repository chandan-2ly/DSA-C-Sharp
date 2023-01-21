namespace CabBooking.Models
{
    public class Cab
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Driver DriverDetails { get; private set; }
        public bool IsAvailable { get; private set; }
        public CabStatus CabStatus { get; private set; }
        public Trip? CurrentTrip { get; private set; }
        public Location CurrentLocation { get; set; }

        public Cab(int id, string name, Driver driverDetails)
        {
            Id = id;
            Name = name;
            DriverDetails = driverDetails;
            IsAvailable = true;
            CabStatus = CabStatus.AVAIALBLE;
            CurrentTrip = null;
        }

        public void UpdateStatus(CabStatus status)
        {
            CabStatus = status;
        }

        public void UpdateLocation(Location location)
        {
            this.CurrentLocation = location;
        }

        public void UpdateAvailability(bool availability)
        {
            this.IsAvailable = availability;
        }

        public void UpdateCurrentTrip(Trip? trip)
        {
            CurrentTrip = trip;
        }

    }
}