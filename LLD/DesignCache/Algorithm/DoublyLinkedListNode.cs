namespace DesignCache.Algorithm
{
    public class DoublyLinkedListNode<Type>
    {
        public Type? Data;
        public DoublyLinkedListNode<Type> next;
        public DoublyLinkedListNode<Type> prev;

        public DoublyLinkedListNode(Type? data)
        {
            Data = data;
            this.next = null;
            this.prev = null;
        }
        public DoublyLinkedListNode()
        {
            Data = default(Type);
            this.next = null;
            this.prev = null;
        }
    }
}
