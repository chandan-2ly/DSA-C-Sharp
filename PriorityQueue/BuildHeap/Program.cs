using System;

namespace BuildHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 1, 5, 6, 7, 9 };
            Heap h = buildHeap(nums);

            Console.WriteLine(string.Join(',', h));
        }
    }
}