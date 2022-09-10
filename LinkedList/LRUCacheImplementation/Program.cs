namespace LRUCacheImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] nums = { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 3 }, new int[] { 4, 4 } };
            int capacity = 2;
            LRUCache obj = new LRUCache(capacity);
            obj.Put(1,0);
            obj.Put(2,2);
            Console.WriteLine(obj.Get(1));
            obj.Put(3,3);
            Console.WriteLine(obj.Get(2));
            obj.Put(4,4);
            Console.WriteLine(obj.Get(1));
            Console.WriteLine(obj.Get(3));
            Console.WriteLine(obj.Get(4));
        }
    }
}