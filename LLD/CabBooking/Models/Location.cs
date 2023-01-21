namespace CabBooking.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Location(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public double Distance(Location location)
        {
            return Math.Sqrt(
                Math.Pow((location.XCoordinate - this.XCoordinate), 2) 
                + Math.Pow((location.YCoordinate - this.YCoordinate), 2)
            );
        }
    }
}