using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHeap
{
    public class Heap
    {
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        public int[] Arr { get;private set; }
        public int HeapType { get; set; }

        public Heap(int capacity, int heapType)
        {
            Capacity = capacity;
            Count = 0;
            Arr = new int[capacity];
            HeapType = heapType;
        }

        public static int GetMax(Heap h)
        {
            if (h == null || h.Count == 0)
                return -1;
            if(h.HeapType == 1)     //max heap
                return h.Arr[0];
            return h.Arr[h.Count - 1];      //min heap
        }

        public static int GetMin(Heap h)
        {
            if (h == null || h.Count == 0)
                return -1;
            if (h.HeapType == 0)     //min heap
                return h.Arr[0];
            return h.Arr[h.Count - 1];      //max heap
        }

        public static int FindParent(Heap h, int i)
        {
            int p = (i - 1) / 2;
            if (p < 0) { return -1; }
            return p;
        }

        public static int FindLeftChild(Heap h, int node)
        {
            int leftChild = 2 * node + 1;
            if (leftChild > h.Count - 1)
                return -1;
            return leftChild;
        }

        public static int FindRightChild(Heap h, int node)
        {
            int rightChild = 2 * node + 2;

            if (rightChild > h.Count - 1)
                return -1;
            return rightChild;
        }

        public static void PerculateDown(Heap h, int i)
        {
            throw new NotImplementedException();
        }
    }
}
