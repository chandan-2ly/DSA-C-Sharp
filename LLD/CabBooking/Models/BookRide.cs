namespace CabBooking.Models
{
    public class BookRide
    {
        public int RiderId { get; set; }
        public Location FromLocation { get; set; }
        public Location ToLocation { get; set; }
    }
}
