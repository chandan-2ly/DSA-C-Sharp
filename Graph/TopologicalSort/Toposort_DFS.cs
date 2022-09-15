namespace TopologicalSort
{
    internal static class Toposort_DFS
    {
        public static List<int> TopoSort(int numCourses, List<List<int>> adj)
        {
            bool[] visited = new bool[numCourses];
            Stack<int> stack = new Stack<int>();
            Array.Fill(visited, false);

            List<int> result = new List<int>();

            for (int i = 0; i < numCourses; i++)
            {
                if (!visited[i])
                {
                    dfsTraversal(i, adj, visited, stack);
                }
            }

            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
            }

            return result;
        }

        private static void dfsTraversal(int src, List<List<int>> adj, bool[] visited, Stack<int> stack)
        {
            visited[src] = true;

            if (adj[src].Count > 0)
            {
                foreach (int next in adj[src])
                {
                    if (!visited[next])
                    {
                        dfsTraversal(next, adj, visited, stack);
                    }
                }
            }
            stack.Push(src);
        }
    }
}
