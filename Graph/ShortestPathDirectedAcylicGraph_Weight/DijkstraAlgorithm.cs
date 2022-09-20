using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathDirectedAcylicGraph_Weight
{
    internal class DijkstraAlgorithm
    {
        public static void ShortestPath(List<List<Weight>> adj, int n, int src)
        {
            int[] distance = new int[n];
            Array.Fill(distance, int.MaxValue);
            distance[src] = 0;

            PriorityQueue<Weight, int> priorityQueue = new PriorityQueue<Weight,int>();
            priorityQueue.Enqueue(new Weight(src, 0), 0);

            while(priorityQueue.Count > 0)
            {
                Weight temp = priorityQueue.Dequeue();
                if (adj[temp.node].Count > 0)
                {
                    foreach(Weight child in adj[temp.node])
                    {
                        int newDistance = child.weight + distance[temp.node];
                        if(newDistance < distance[child.node])
                        {
                            distance[child.node] = newDistance;
                            priorityQueue.Enqueue(child, child.weight);
                        }
                    }
                }
            }

            Console.WriteLine("DijkstraAlgo -> "+string.Join(',', distance));
        }
    }
}
