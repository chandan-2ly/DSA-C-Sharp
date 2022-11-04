namespace ClimbingStairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int ways = ClimbStairs.Climb(n);
            Console.WriteLine(ways);
            bool status = true;
            try
            {
                throw new Exception("failed");
            }
            catch(Exception ex)
            {
                status = false;
                throw;
            }
            Console.WriteLine(status);
        }
    }
}