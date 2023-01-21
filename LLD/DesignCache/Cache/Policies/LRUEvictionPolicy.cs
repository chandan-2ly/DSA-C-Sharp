using DesignCache.Algorithm;

namespace DesignCache.Cache.Policies
{
    public class LRUEvictionPolicy<Key> : IEvictionPolicy<Key>
    {
        private DoublyLinkedList<Key> dll;
        private Dictionary<Key, DoublyLinkedListNode<Key>> map;

        public LRUEvictionPolicy()
        {
            dll = new DoublyLinkedList<Key>();
            map = new Dictionary<Key, DoublyLinkedListNode<Key>>();
        }

        public Key? EvictKey()
        {
            DoublyLinkedListNode<Key> lastNode = dll.GetLastNode();
            if(lastNode == null)
            {
                return default(Key);
            }
            dll.DetachNode(lastNode);
            return lastNode.Data;
        }

        public void KeyAccessed(Key key)
        {
            if (map.ContainsKey(key))
            {
                dll.DetachNode(map[key]);
                dll.InsertNodeAtFirst(map[key]);
            }
            else
            {
                DoublyLinkedListNode<Key> newNode = new DoublyLinkedListNode<Key>(key);
                map[key] = newNode;
                dll.InsertNodeAtFirst(newNode);
            }
        }
    }
}
