namespace LRUCacheImplementation
{
    public class LRUCache
    {
        private Dictionary<int, Node> dict;
        private Node head;
        private Node tail;
        private int capacity;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            dict = new Dictionary<int, Node>();
            head = new Node();
            tail = new Node();

            head.next = tail;
            tail.prev = head;
        }
        public int Get(int key)
        {
            int ans = -1;

            if (!dict.ContainsKey(key))
            {
                return ans;
            }
            Node node = dict[key];
            ans = node.val;

            remove(node);
            insert(node);

            return ans;
        }

        private void insert(Node node)
        {
            dict[node.key] = node;
            Node headNext = head.next;
            node.next = headNext;
            headNext.prev = node;
            head.next = node;
            node.prev = head;
        }

        private void remove(Node node)
        {
            dict.Remove(node.key);
            Node nodeNext = node.next;
            Node nodePrev = node.prev;
            nodePrev.next = nodeNext;
            nodeNext.prev = nodePrev;

        }

        public void Put(int key, int value)
        {
            if (dict.ContainsKey(key))
            {
                remove(dict[key]);
            }
            
            if(dict.Count == capacity)
            {
                remove(tail.prev);
            }
            insert(new Node(key, value));            
        }
    }
}
