using System;
using System.Collections.Generic;

namespace DetectCycleInUndirectedGraphDFS
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[][] prerequisites = {
                new int[]{ 1, 4 },
                new int[] { 2, 4 },
                new int[]{ 3, 1 },
                new int[] { 3, 2 }
            };
            int numCourses = 5;
            bool canFinish = CanFinish(numCourses, prerequisites);
            Console.WriteLine(canFinish);
        }

        private static bool CanFinish(int numCourses, int[][] prerequisites)
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
                    if (dfsCycleExist(i, visited, adj))
                        return false;
            }
            return true; ;
        }

        private static bool dfsCycleExist(int src, int[] visited, List<List<int>> adj)
        {
            if (visited[src] == 1)
                return true;
            visited[src] = 1;

            if (adj[src].Count > 0)
            {
                foreach(int next in adj[src])
                {
                    if(visited[next] != 2)
                        if(dfsCycleExist(next, visited, adj))
                            return true;
                }
            }
            visited[src] = 2;
            return false;
        }
    }
}
