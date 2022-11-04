namespace MergeKSortedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode root1 = new ListNode(1);
            root1.next = new ListNode(4);
            root1.next.next = new ListNode(5);

            ListNode root2 = new ListNode(1);
            root2.next = new ListNode(3);
            root2.next.next = new ListNode(4);

            ListNode root3 = new ListNode(2);
            root3.next = new ListNode(6);

            ListNode[] lists = new ListNode[] {root1, root2, root3};
            ListNode result = MergeKLists(new ListNode[] {null});
            Console.WriteLine(result);
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            PriorityQueue<ListNode, int> minHeap =
                    new PriorityQueue<ListNode, int>(Comparer<int>.Create((x, y) => x - y));
            for (int i = 0; i < lists.Length; i++)
            {
                minHeap.Enqueue(lists[i], lists[i].val);
            }

            ListNode dummy = new ListNode();
            ListNode curr = dummy;

            while (minHeap.Count > 0)
            {
                ListNode node = minHeap.Dequeue();
                ListNode next = node.next;
                curr.next = node;
                curr = curr.next;
                if (next != null)
                {
                    minHeap.Enqueue(next, next.val);
                }
            }
            return dummy.next;
        }
    }
}