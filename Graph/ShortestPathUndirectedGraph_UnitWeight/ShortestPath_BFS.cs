using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathUndirectedGraph_UnitWeight
{
    internal static class ShortestPath_BFS
    {
        public static void ShortestPath(List<List<int>> adj, int n, int source)
        {
            int[] distance = new int[n];
            Array.Fill(distance, int.MaxValue);

            distance[source] = 0;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                if (adj[node].Count > 0)
                {
                    foreach (int next in adj[node])
                    {
                        if ((distance[node] + 1) < distance[next])
                        {
                            distance[next] = distance[node] + 1;
                            queue.Enqueue(next);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(",", distance));
        }
    }
}
