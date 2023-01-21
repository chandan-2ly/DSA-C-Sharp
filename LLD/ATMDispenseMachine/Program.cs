namespace ATMDispenseMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAmountDispenser dispenser = new Rupees2000Dispenser();
            IAmountDispenser dispenser100 = new Rupees100Dispenser();
            IAmountDispenser dispenser200 = new Rupees200Dispenser();
            IAmountDispenser dispenser500 = new Rupees500Dispenser();

            dispenser.SetNextDispenser(dispenser500);
            dispenser500.SetNextDispenser(dispenser200);
            dispenser200.SetNextDispenser(dispenser100);

            while (true)
            {
                Console.WriteLine("Enter amount to Dispense");
                int amount = Convert.ToInt32(Console.ReadLine());

                if(amount <= 0 || amount % 100 != 0)
                {
                    Console.WriteLine("Please enter amount multiples of 100");
                }
                else
                {
                    dispenser.DispenceAmount(new Currency(amount));
                }
            }
        }
    }
}