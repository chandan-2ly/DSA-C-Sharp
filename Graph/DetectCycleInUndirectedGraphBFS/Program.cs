using System;
using System.Collections.Generic;

//not passing all test cases, need to check
namespace DetectCycleInUndirectedGraphBFS
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[][] prerequisites = { 
            //    new int[]{ 1, 4 }, 
            //    new int[] { 2, 4 },
            //    new int[]{ 3, 1 },
            //    new int[] { 3, 2 }
            //};
            //int numCourses = 5;
            //int[][] prerequisites = {
            //    new int[]{ 1, 0 },
            //    new int[] { 0, 1 }

            //};
            //int numCourses = 2;

            int[][] prerequisites = {
                new int[]{ 0, 1 },
                new int[] { 3, 1 },
                new int[]{ 1, 3 },
                new int[] { 3, 2 }
            };
            int numCourses = 4;
            bool canFinish = CanFinish(numCourses, prerequisites);
            Console.WriteLine(canFinish);
        }
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
                    if (bfsCycleExist(i, visited, adj))
                        return false;
            }
            return true;
        }
        private static bool bfsCycleExist(int src, int[] visited, List<List<int>> adj)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(src);

            while (queue.Count != 0)
            {
                int u = queue.Dequeue();

                if (visited[u] == 1)
                    return true;

                visited[u] = 1;

                if (adj[u].Count > 0)
                {
                    foreach (int next in adj[u])
                    {
                        if (visited[next] == 1)
                            return true;

                        if (visited[next] != 2)
                        {
                            queue.Enqueue(next);
                            //visited[next] = 1;
                        }
                    }
                }
                if (queue.Count == 0)
                    visited[u] = 2;
                
            }
            visited[src] = 2;

            return false;
        }
    }
}
