using DesignCache.Cache.Exceptions;

namespace DesignCache.Cache.Storage
{
    public class HashMapBasedStorage<Key, Value> : IStorage<Key, Value>
    {
        private Dictionary<Key, Value> _storage;
        public int Capacity { get; private set; }

        public HashMapBasedStorage(int capacity)
        {
            _storage = new Dictionary<Key, Value>();
            Capacity = capacity;
        }

        public void Add(Key key, Value value)
        {
            if (_storage.Count == Capacity)
                throw new StorageFullException("Storage is full");
            _storage[key] = value;
        }

        public Value Get(Key key)
        {
            if (!_storage.ContainsKey(key))
            {
                throw new NotFoundException("Key does not exist");
            }
            return _storage[key];
        }

        public void Remove(Key key)
        {
            if (!_storage.ContainsKey(key))
            {
                throw new NotFoundException("Key does not exist");
            }
            _storage.Remove(key);
        }
    }
}
