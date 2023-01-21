namespace DesignCache.Algorithm
{
    public class DoublyLinkedList<Type>
    {
        private DoublyLinkedListNode<Type> head;
        private DoublyLinkedListNode<Type> tail;

        public DoublyLinkedList()
        {
            head = new DoublyLinkedListNode<Type>();
            tail = new DoublyLinkedListNode<Type>();

            head.next = tail;
            tail.prev = head;
        }

        public DoublyLinkedListNode<Type> GetFirstNode()
        {
            if(head.next != tail)
            {
                return head.next;
            }
            return null;
        }

        public DoublyLinkedListNode<Type> GetLastNode()
        {
            if(tail.prev != head)
            {
                return tail.prev;
            }
            return null;
        }

        public void AddElementAtLast(Type elem)
        {
            if(elem == null)
            {
                throw new Exception("Elem cannot be null");
            }

            AddNodeAtLast(new DoublyLinkedListNode<Type>(elem));
        }

        public void AddNodeAtLast(DoublyLinkedListNode<Type> node)
        {
            var lastNode = tail.prev;
            lastNode.next = node;
            node.prev = lastNode;
            node.next = tail;
            tail.prev = node;
        }

        public void DetachNode(DoublyLinkedListNode<Type> node)
        {
            if(node != null)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;
            }
        }

        public void InsertNodeAtFirst(DoublyLinkedListNode<Type> node)
        {
            if(node != null)
            {
                var nextNode = head.next;
                node.next = nextNode;
                nextNode.prev = node;
                head.next = node;
                node.prev = head;
            }
        }

        public void RemoveNodeFromLast(DoublyLinkedListNode<Type> node)
        {
            if (node != null)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;
            }
        }
    }
}
