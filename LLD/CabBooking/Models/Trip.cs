namespace CabBooking.Models
{
    public class Trip
    {
        public int Id { get; }
        public Rider RiderDetails { get; }
        public Cab CabDetails { get; }
        public double Price { get; }
        public Location FromLocation { get; }
        public Location ToLocation { get; }
        public TripStatus TripStatus { get; private set; }

        public Trip(int id, Rider riderDetails, Cab cabDetails, double price, Location fromLocation, Location toLocation)
        {
            Id = id;
            RiderDetails = riderDetails;
            CabDetails = cabDetails;
            Price = price;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TripStatus = TripStatus.IN_PROGRESS;
        }

        public void EndTrip()
        {
            this.TripStatus = TripStatus.FINISHED;
        }
    }
}