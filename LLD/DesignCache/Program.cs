using DesignCache.Cache;
using DesignCache.Cache.CacheFactory;

namespace DesignCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CacheFactory<int, int> cacheFactory = new CacheFactory<int, int>();
            Cache<int, int> cache = cacheFactory.DefaultCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);
            Console.WriteLine(cache.Get(1));
            cache.Put(3, 3);
            Console.WriteLine(cache.Get(2));
            cache.Put(4, 4);
            Console.WriteLine(cache.Get(1));
            Console.WriteLine(cache.Get(3));
            Console.WriteLine(cache.Get(4));
        }
    }
}