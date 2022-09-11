namespace CourseSchedule
{
    public static class CanFinish_BFS
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

            int[] indegree = new int[numCourses];
            Array.Fill(indegree, 0);

            foreach (List<int> item in adj)
            {
                foreach (int node in item)
                {
                    indegree[node]++;
                }
            }
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < indegree.Length; i++)
            {
                if (indegree[i] == 0)
                    queue.Enqueue(i);
            }

            while (queue.Count != 0)
            {
                int u = queue.Dequeue();

                if (adj[u].Count > 0)
                {
                    foreach (int next in adj[u])
                    {
                        indegree[next]--;

                        if (indegree[next] == 0)
                            queue.Enqueue(next);
                    }
                }
            }

            for (int i = 0; i < indegree.Length; i++)
            {
                if (indegree[i] != 0)
                    return false;
            }

            return true;
        }
    }
}
