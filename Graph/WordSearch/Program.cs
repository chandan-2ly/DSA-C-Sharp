namespace WordSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char[][] board = { new char[] { 'A', 'B', 'C', 'E' }, 
            //    new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
            //string word = "ABCCED";

            char[][] board = { new char[] { 'A', 'A' }};
            string word = "AAA";

            Solution solution = new Solution();
            Console.WriteLine(solution.Exist(board, word));
        }
    }
}