namespace ShortestPathUndirectedGraph_UnitWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> adj = new List<List<int>>
            {
                new List<int>{1,3},
                new List<int>{0,2,3},
                new List<int>{1,6},
                new List<int> {0,4},
                new List<int> {3,5},
                new List<int> {4,6},
                new List<int> {2,5,7,8},
                new List<int> {6,8},
                new List<int> {6,7}
            };
            int nodeCount = 9;
            int sourceNode = 0;
            ShortestPath_BFS.ShortestPath(adj, nodeCount, sourceNode);
        }
    }
}