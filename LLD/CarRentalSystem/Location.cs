namespace CarRentalSystem
{
    public class Location
    {
        public int id { get;}
        private string Address { get;}
        private string City { get;}
        private int PinCode { get;}

        public Location(int id, string address, string city, int pinCode)
        {
            this.id = id;
            Address = address;
            City = city;
            PinCode = pinCode;
        }

    }
}