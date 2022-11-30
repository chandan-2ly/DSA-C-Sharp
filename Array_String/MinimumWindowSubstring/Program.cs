namespace MinimumWindowSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";

            string resutl = MinimumWindow.MinWindow(s, t);

            Console.WriteLine(resutl);
        }
    }
}