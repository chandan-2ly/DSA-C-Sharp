using DesignCache.Cache.Exceptions;
using DesignCache.Cache.Policies;
using DesignCache.Cache.Storage;

namespace DesignCache.Cache
{
    public class Cache<Key, Value>
    {
        private IEvictionPolicy<Key> _evictionPolicy;
        private IStorage<Key, Value> _storage;

        public Cache(IEvictionPolicy<Key> evictionPolicy, IStorage<Key, Value> storage)
        {
            _evictionPolicy = evictionPolicy;
            _storage = storage;
        }

        public void Put(Key key, Value val)
        {
            try
            {
                _storage.Add(key, val); ;
                _evictionPolicy.KeyAccessed(key);
            }
            catch(StorageFullException ex)
            {
                Console.WriteLine("Storage is Full, will try to evict");
                Key keyToRemove = _evictionPolicy.EvictKey();

                if(keyToRemove == null)
                {
                    throw new Exception("Runtime Exception, unstable state");
                }

                _storage.Remove(keyToRemove);
                Console.WriteLine("Created Space after evicting" + keyToRemove);
                Put(key, val);
            }
        }

        public Value Get(Key key)
        {
            try
            {
                Value val = _storage.Get(key);
                _evictionPolicy.KeyAccessed(key);
                return val;
            }
            catch(NotFoundException ex)
            {
                Console.WriteLine("Trying to access non existing key");
                return default(Value);
            }
        }
    }
}
