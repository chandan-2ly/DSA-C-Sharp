namespace CarRentalSystem
{
    public class Bill
    {
        public int Id { get; set; }
        private Reservation reservation;
        public bool isPaid;
        long Amount;

        public Bill(Reservation reservation)
        {
            this.reservation = reservation;
            Id = 1;
            isPaid = false;
            Amount = ComputeBillAmount();
        }

        private long ComputeBillAmount()
        {
            //calculate the bill amount and return
            return 1000;
        }
    }
}