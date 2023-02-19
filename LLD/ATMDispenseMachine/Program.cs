namespace ATMDispenseMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(10000);
            Card card = new Card(123456, "DigiBank", 123, "Chandan", bankAccount, 1234);
            User user = new User(1, "Chandan", card, bankAccount);
            AtmRoom atmRoom = new AtmRoom(user, card);

            while (true)
            {
                Console.WriteLine("Enter amount to withdraw");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount <= 0 || amount % 100 != 0)
                {
                    Console.WriteLine("Please enter amount multiples of 100");
                    return;
                }

                atmRoom.AtmMachine.DisplayAtmStatus();
                atmRoom.AtmMachine.CurrentAtmState.InsertCard(atmRoom.AtmMachine, card);
                atmRoom.AtmMachine.CurrentAtmState.AuthenticatePin(atmRoom.AtmMachine, atmRoom.User.CardDetails, 1234);
                atmRoom.AtmMachine.CurrentAtmState.SelectOperation(atmRoom.AtmMachine, atmRoom.User.CardDetails, TransactionType.CASH_WITHDRAWAL);
                atmRoom.AtmMachine.CurrentAtmState.CashWithdrawal(atmRoom.AtmMachine, atmRoom.User.CardDetails, amount);
                atmRoom.AtmMachine.DisplayAtmStatus();
            }

            
        }
    }
}