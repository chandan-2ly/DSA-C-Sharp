using System.Security.Cryptography.X509Certificates;

namespace SkyLineProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] building =
                new int[][] { new int[] { 2, 9, 10 }, new int[] { 3, 7, 15 }, new int[] { 5, 12, 12 }, new int[] { 15, 20, 10 }, new int[] { 19, 24, 8 } };
            //int[][] building =
            //    new int[][] { new int[] { 0, 2, 3 }, new int[] { 2, 5, 3 }};
            var result = Solution.GetSkyline(building);

            foreach (var row in result)
            {
                foreach (var column in row)
                {
                    Console.WriteLine(column);
                }
            }
        }
    }
    public static class Solution
    {
        public static IList<IList<int>> GetSkyline(int[][] buildings)
        {
            List<(int left, int height)> list = new List<(int left, int height)>();
            for (int i = 0; i < buildings.Length; i++)
            {
                int lh = buildings[i][0];
                int rh = buildings[i][1];
                int ht = buildings[i][2];

                list.Add((lh, -ht));
                list.Add((rh, ht));
            }

            list.Sort((x, y) =>
            {
                if (x.left == y.left)
                    return x.height.CompareTo(y.height);
                return x.left.CompareTo(y.left);
            });

            SortedSet<int> sortedSet = new SortedSet<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            sortedSet.Add(0);
            map.Add(0, 1);
            IList<IList<int>> result = new List<IList<int>>();
            int currHt = 0;
            foreach (var point in list)
            {
                if (point.height < 0)        //it is starting point, add it to sorted list and answer
                {
                    if (sortedSet.Contains(-point.height)){
                        map[-point.height]++;
                    }
                    else
                    {
                        sortedSet.Add(-point.height);
                        map.Add(-point.height, 1);
                    }
                    
                }
                else
                {
                    map[point.height]--;
                    if (map[point.height] == 0)
                    {
                        sortedSet.Remove(point.height);
                        map.Remove(point.height);
                    }
                        
                }
                int topHt = sortedSet.ElementAt(sortedSet.Count - 1);
                if (currHt != topHt)
                {
                    result.Add(new List<int> { point.left, topHt });
                    currHt = topHt;
                }
            }

            return result;
        }
    }
    
}