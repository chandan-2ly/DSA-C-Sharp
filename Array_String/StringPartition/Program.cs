namespace StringPartition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res = solution.Partition("ab");
            Console.WriteLine(res);
        }
    }
}