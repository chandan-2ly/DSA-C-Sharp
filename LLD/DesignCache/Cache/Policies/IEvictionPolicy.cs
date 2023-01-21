namespace DesignCache.Cache.Policies
{
    public interface IEvictionPolicy<Key>
    {
        public void KeyAccessed(Key key);
        public Key EvictKey();
    }
}
