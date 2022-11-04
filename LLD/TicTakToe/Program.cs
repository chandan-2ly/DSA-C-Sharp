namespace TicTakToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TickTackToeGame game = new TickTackToeGame();
            game.InitializeGame();
            Console.WriteLine("The Game winner is: " + game.StartGame());
        }
    }
}