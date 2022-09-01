namespace TopologicalSort_BFS
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<List<int>> adj = new List<List<int>>
            //{
            //    new List<int>{},
            //    new List<int>{0},
            //    new List<int>{0},
            //    new List<int> {0}
            //};

            //int numCourses = 4;

            List<List<int>> adj = new List<List<int>>
            {
                new List<int>{},
                new List<int>{3},
                new List<int>{3},
                new List<int> {},
                new List<int> {0,1},
                new List<int> {0,2}
            };

            int numCourses = 6;
            List<int> sortedElem = TopoSort(numCourses, adj);
            Console.WriteLine(String.Join(' ', sortedElem));
        }

        private static List<int> TopoSort(int V, List<List<int>> adj)
        {
            int[] indegree = new int[V];
            List<int> result = new List<int>();
            Queue<int> queue = new Queue<int>();

            Array.Fill(indegree, 0);
            foreach(List<int> list in adj)
            {
                foreach(int node in list)
                {
                    indegree[node]++;
                }
            }

            for(int i = 0; i < indegree.Length; i++)
            {
                if(indegree[i] == 0)
                    queue.Enqueue(i);
            }

            while(queue.Count > 0)
            {
                int node = queue.Dequeue();
                result.Add(node);

                if(adj[node].Count > 0)
                {
                    foreach(int next in adj[node])
                    {
                        indegree[next]--;

                        if (indegree[next] == 0)
                            queue.Enqueue(next);
                    }
                }
            }
            return result;
        }
    }
}