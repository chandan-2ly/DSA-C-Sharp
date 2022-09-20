namespace ShortestPathDirectedAcylicGraph_Weight
{
    internal static class ShortestPath_DFS
    {
        public static void ShortestPath(List<List<Weight>> adj, int n, int source)
        {
            Stack<int> topologicalOrdered = new Stack<int>();
            bool[] visited = new bool[n];
            Array.Fill(visited, false);

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    dfs(adj, topologicalOrdered, i, visited);
                }
            }

            int[] distance = new int[n];
            Array.Fill(distance, int.MaxValue);

            distance[source] = 0;

            while (topologicalOrdered.Count > 0)
            {
                int tempNode = topologicalOrdered.Pop();
                if (adj[tempNode].Count > 0)
                {
                    foreach (Weight next in adj[tempNode])
                    {
                        if ((distance[tempNode] + next.weight) < distance[next.node])
                        {
                            distance[next.node] = distance[tempNode] + next.weight;
                        }
                    }
                }
            }

            Console.WriteLine("DFS -> " + string.Join(",", distance));
        }

        private static void dfs(List<List<Weight>> adj, Stack<int> stack, int src, bool[] visited)
        {
            visited[src] = true;

            if (adj[src].Count > 0)
            {
                foreach(Weight next in adj[src])
                {
                    if (!visited[next.node])
                    {
                        dfs(adj, stack, next.node, visited);
                    }
                }
            }
            stack.Push(src);
        }
    }
}
