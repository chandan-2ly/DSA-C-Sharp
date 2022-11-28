namespace CarRentalSystem
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string DrivingLicense { get; private set; }

        public User(int id, string name, string license)
        {
            Id = id;
            Name = name;
            DrivingLicense = license;
        }
    }
}