﻿namespace ShortestPathDirectedAcylicGraph_Weight
{
    class Weight
    {
        public int node { get; set; }
        public int weight { get; set; }

        public Weight(int _node, int _weight)
        {
            node = _node;
            weight = _weight;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<Weight>> adj = new List<List<Weight>>
            {
                new List<Weight>
                {
                    new Weight(1, 2),
                    new Weight(4, 1)
                },
                new List<Weight>
                {
                    new Weight(2, 3)
                },
                new List<Weight>
                {
                    new Weight(3,6)
                },
                new List<Weight>(),
                new List<Weight>
                {
                    new Weight(2,2),
                    new Weight(5,4)
                },
                new List<Weight>
                {
                    new Weight(3,1)
                }
            };
            int nodeCount = 6;
            int sourceNode = 0;
            ShortestPath_BFS.ShortestPath(adj, nodeCount, sourceNode);
            ShortestPath_DFS.ShortestPath(adj, nodeCount, sourceNode);
        }

        
    }
}