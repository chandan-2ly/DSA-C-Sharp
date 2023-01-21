using DesignCache.Cache.Policies;
using DesignCache.Cache.Storage;

namespace DesignCache.Cache.CacheFactory
{
    public class CacheFactory<Key, Value>
    {
        public Cache<Key, Value> DefaultCache(int capacity)
        {
            return new Cache<Key, Value>(new LRUEvictionPolicy<Key>(), new HashMapBasedStorage<Key, Value>(capacity));
        }
    }
}
