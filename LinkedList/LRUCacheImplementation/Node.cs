namespace LRUCacheImplementation
{
    public class Node
    {
        public int val;
        public int key;
        public Node next;
        public Node prev;

        public Node()
        {
            val = -1;
            key = -1;
        }
        public Node(int key, int val)
        {
            this.key = key;
            this.val = val;
        }
    }
}
