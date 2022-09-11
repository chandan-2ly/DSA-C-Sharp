using System;

namespace IsGraphBipartite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] graph = { new int[] { 1, 2, 3 }, new int[] { 0, 2 }, new int[] { 0, 1, 3 }, new int[] { 0, 2 } };
            
            bool result = IsBipartite_BFS.IsBipartite(graph);
            Console.WriteLine(result);

            result = IsBipartite_DFS.IsBipartite(graph);
            Console.WriteLine(result);
        }
    }
}