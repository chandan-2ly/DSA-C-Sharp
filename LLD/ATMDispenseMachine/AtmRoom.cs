using ATMDispenseMachine.ATMDispenser;

namespace ATMDispenseMachine
{
    public class AtmRoom
    {
        public Atm AtmMachine { get; set; }
        public User User { get; set; }
        public Card Card { get; set; }

        public AtmRoom(User user, Card card)
        {
            User = user;
            Card = card;
            InitializeAtmMachine();
        }

        private void InitializeAtmMachine()
        {
            IAmountDispenser dispenser = new Rupees2000Dispenser();
            IAmountDispenser dispenser100 = new Rupees100Dispenser();
            IAmountDispenser dispenser200 = new Rupees200Dispenser();
            IAmountDispenser dispenser500 = new Rupees500Dispenser();

            dispenser.SetNextDispenser(dispenser500);
            dispenser500.SetNextDispenser(dispenser200);
            dispenser200.SetNextDispenser(dispenser100);

            Dictionary<int, int> noteWithCount = new Dictionary<int, int>();
            noteWithCount.Add((int)NoteType.TWOTHOUSAND, 5);
            noteWithCount.Add((int)NoteType.FIVEHUNDRED, 5);
            noteWithCount.Add((int)NoteType.TWOHUNDRED, 5);
            noteWithCount.Add((int)NoteType.ONEHUNDRED, 5);

            AtmMachine = new Atm(noteWithCount, dispenser);
        }
    }
}
