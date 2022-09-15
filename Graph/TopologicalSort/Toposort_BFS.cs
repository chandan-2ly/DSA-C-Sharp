namespace TopologicalSort
{
    internal static class Toposort_BFS
    {
        public static List<int> TopoSort(int V, List<List<int>> adj)
        {
            int[] indegree = new int[V];
            List<int> result = new List<int>();
            Queue<int> queue = new Queue<int>();

            Array.Fill(indegree, 0);
            foreach (List<int> list in adj)
            {
                foreach (int node in list)
                {
                    indegree[node]++;
                }
            }

            for (int i = 0; i < indegree.Length; i++)
            {
                if (indegree[i] == 0)
                    queue.Enqueue(i);
            }

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                result.Add(node);

                if (adj[node].Count > 0)
                {
                    foreach (int next in adj[node])
                    {
                        indegree[next]--;

                        if (indegree[next] == 0)
                            queue.Enqueue(next);
                    }
                }
            }
            return result;
        }
    }
}
