namespace CabBooking.Models
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Driver(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}