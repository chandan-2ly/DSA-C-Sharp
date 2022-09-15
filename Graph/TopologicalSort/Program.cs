namespace TopologicalSort
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
            List<int> sortedElem = Toposort_BFS.TopoSort(numCourses, adj);
            Console.WriteLine(String.Join(' ', sortedElem));

            sortedElem = Toposort_DFS.TopoSort(numCourses, adj);
            Console.WriteLine(String.Join(' ', sortedElem));
        }

        
    }
}