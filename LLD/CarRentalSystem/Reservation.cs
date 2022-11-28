namespace CarRentalSystem
{
    public class Reservation
    {
        public int reservationId { get; set; }
        public User User { get; set; }
        public Vehicle Vehicle { get; set; }
        public Bill Bill { get; set; }

        public DateTime BookingDate { get; set; }
        public DateOnly DateBookedFrom { get; set; }
        public DateOnly DateBookedTo { get; set; }
        public TimeOnly TimeBookedFrom { get; set; }
        public TimeOnly TimeBookedTo { get; set; }
        public Location PickUpLocation { get; set; }
        public Location DropLocation { get; set; }
        public Location ReservationLocation { get; set; }
        public ReservationStatus Status { get; set; }
        public ReservetionType Type { get; set; }

        public int CreateReserve(User user, Vehicle vehicle)
        {
            reservationId = 1;
            User = user;
            Vehicle = vehicle;
            Type = ReservetionType.HOURLY;
            Status = ReservationStatus.SCHEDULED;

            return reservationId;
        }


    }
}