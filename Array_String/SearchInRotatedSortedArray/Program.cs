namespace SearchInRotatedSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            int index = SearchInRotatedArray.Search(nums, target);
            Console.WriteLine(index);
        }
    }
}