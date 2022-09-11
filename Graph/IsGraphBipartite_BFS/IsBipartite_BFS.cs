namespace IsGraphBipartite
{
    public static class IsBipartite_BFS
    {
        public static bool IsBipartite(int[][] graph)
        {
            int[] isColoured = new int[graph.Length];
            Array.Fill(isColoured, -1);

            for (int i = 0; i < graph.Length; i++)
            {
                if (isColoured[i] == -1)
                {
                    if (!IsBipartiteBFS(i, isColoured, graph))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsBipartiteBFS(int src, int[] isColoured, int[][] graph)
        {
            isColoured[src] = 1;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(src);

            while (queue.Count > 0)
            {
                int elem = queue.Dequeue();

                if (graph[elem].Length > 0)
                {
                    foreach (int next in graph[elem])
                    {
                        if (isColoured[next] == -1)
                        {
                            isColoured[next] = 1 - isColoured[elem];
                            queue.Enqueue(next);
                        }
                        else if (isColoured[next] == isColoured[elem])
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
