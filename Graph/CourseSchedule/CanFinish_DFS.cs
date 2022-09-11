namespace CourseSchedule
{
    public static class CanFinish_DFS
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            int[] visited = new int[numCourses];
            Array.Fill(visited, 0);

            List<List<int>> adj = new List<List<int>>();

            for (int i = 0; i < numCourses; i++)
            {
                adj.Add(new List<int>());
            }

            foreach (int[] item in prerequisites)
            {
                adj[item[0]].Add(item[1]);
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (visited[i] == 0)
                    if (DfsCycleExist(i, visited, adj))
                        return false;
            }
            return true; ;
        }

        private static bool DfsCycleExist(int i, int[] visited, List<List<int>> adj)
        {
            if (visited[i] == 1)
                return true;
            visited[i] = 1;

            if (adj[i].Count > 0)
            {
                foreach (int next in adj[i])
                {
                    if (visited[next] != 2)
                        if (DfsCycleExist(next, visited, adj))
                            return true;
                }
            }
            visited[i] = 2;
            return false;
        }
    }
}
