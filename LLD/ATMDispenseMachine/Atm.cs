using ATMDispenseMachine.ATMDispenser;
using ATMDispenseMachine.ATMStates;

namespace ATMDispenseMachine
{
    public class Atm
    {
        private int AtmBalance { get; set; }
        private Dictionary<int, int> NotesWithCount { get; set; } = new Dictionary<int, int>();
        public AtmStates CurrentAtmState { get; private set; }

        public IAmountDispenser AtmAmountDispenser { get; set; }

        public Atm(Dictionary<int, int> notesWithCount, IAmountDispenser amountDispenser)
        {
            NotesWithCount = notesWithCount;
            AtmAmountDispenser = amountDispenser;
            SetCurrentState(new IdleState());
            SetAtmBalance();
        }

        public int GetAtmBalance()
        {
            return AtmBalance;
        }

        public void SetAtmBalance()
        {
            int amount = 0;
            foreach (var note in NotesWithCount)
            {
                amount += note.Key * note.Value;
            }
            AtmBalance = amount;
        }

        public void SetCurrentState(AtmStates atmState)
        {
            CurrentAtmState = atmState;
        }

        public void DeductNote(NoteType type, int count)
        {
            if (!NotesWithCount.ContainsKey((int)type)){
                Console.WriteLine("Notes not available to deduct");
            }

            NotesWithCount[(int)type] -= count;
            SetAtmBalance();
        }

        public void DisplayAtmStatus()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("ATM Machine Available Balance:     " + AtmBalance);
            foreach(var note in NotesWithCount)
            {
                Console.WriteLine($"{note.Key} note count is:   {note.Value}");
            }
            Console.WriteLine("-------------------------------------------------------");

        }

        public int GetNoteCount(NoteType type)
        {
            if (NotesWithCount.ContainsKey((int)type))
            {
                return NotesWithCount[(int)type];
            }
            return 0;
        }


    }
}
