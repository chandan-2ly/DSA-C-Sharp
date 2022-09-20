namespace ShortestPathDirectedAcylicGraph_Weight
{
    internal static class ShortestPath_BFS
    {
        public static void ShortestPath(List<List<Weight>> adj, int n, int source)
        {
            int[] distance = new int[n];
            Array.Fill(distance, int.MaxValue);

            distance[source] = 0;

            Queue<Weight> queue = new Queue<Weight>();
            queue.Enqueue(new Weight(0, 0));

            while (queue.Count > 0)
            {
                Weight tempNode = queue.Dequeue();
                if (adj[tempNode.node].Count > 0)
                {
                    foreach (Weight next in adj[tempNode.node])
                    {
                        if ((distance[tempNode.node] + next.weight) < distance[next.node])
                        {
                            distance[next.node] = distance[tempNode.node] + next.weight;

                            queue.Enqueue(next);
                        }
                    }
                }
            }

            Console.WriteLine("BFS -> " + string.Join(",", distance));
        }
    }
}
