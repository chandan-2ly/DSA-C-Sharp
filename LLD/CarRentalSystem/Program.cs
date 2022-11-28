namespace CarRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User(1, "Chandan", "KA01"));
            users.Add(new User(2, "Ranjan", "KA02"));

            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle hyundaiCar = new Vehicle(1, "Hyundai", "KA50", VehicleType.CAR, VehicleStatus.ACTIVE, 700, 50);
            Vehicle hondaBike = new Vehicle(2, "Honda Hornet", "KA30", VehicleType.BIKE, VehicleStatus.ACTIVE, 500, 20);
            Vehicle fzBike = new Vehicle(3, "Yamaha FZS", "KA32", VehicleType.BIKE, VehicleStatus.ACTIVE, 500, 20);

            vehicles.Add(fzBike);
            vehicles.Add(hondaBike);
            vehicles.Add(hyundaiCar);

            List<Store> stores = new List<Store>();
            stores.Add(new Store(1, new Location(1, "Yelehanka", "Bangalore", 560060)));
            stores.Add(new Store(2, new Location(1, "JpNagar", "Bangalore", 560060)));

            stores[0].AddVehiclesToInventory(vehicles);

            VehicleRentalSystem rentalSystem = new VehicleRentalSystem(users, stores);

            //User 1 comes in
            User user1 = users.First();

            //user search store based on location
            Location location = new Location(1, "Yelehanka", "Bangalore", 560060);
            Store store = rentalSystem.GetLocationBasedStore(location);

            //Get all the vehicles available in store
            List<Vehicle> availableVehicles = store.GetVehicles(VehicleType.CAR);

            //Reserve the vehicle
            Reservation reservation = store.CreateReservation(availableVehicles[0], user1);

            //Generate the bill
            Bill bill = new Bill(reservation);

            //Make the payment
            Payment payment = new Payment();
            payment.PayBill(bill);

            //Complete the reservation
            store.CompleteReservation(reservation.reservationId);



        }
    }
}