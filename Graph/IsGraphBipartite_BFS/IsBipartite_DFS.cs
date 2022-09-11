namespace IsGraphBipartite
{
    public static class IsBipartite_DFS
    {
        public static bool IsBipartite(int[][] graph)
        {
            int[] isColoured = new int[graph.Length];
            Array.Fill(isColoured, -1);

            for (int i = 0; i < graph.Length; i++)
            {
                if (isColoured[i] == -1)
                {
                    isColoured[i] = 1;
                    if (!IsBipartiteDFS(i, isColoured, graph))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsBipartiteDFS(int src, int[] isColoured, int[][] graph)
        {
            if (graph[src].Length > 0)
            {
                foreach(int next in graph[src])
                {
                    if(isColoured[next] != 1)
                    {
                        isColoured[next] = 1 - isColoured[src];
                        if (!IsBipartiteDFS(next, isColoured, graph))
                            return false;
                    }
                    else if(isColoured[next] == isColoured[src])
                        return false;
                }
            }
            return true;
        }
    }
}
