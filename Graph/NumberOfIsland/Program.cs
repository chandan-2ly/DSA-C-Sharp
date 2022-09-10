namespace NumberOfIsland
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[][] grid = {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '0', '0'}
            };

            int count = numIslands(grid);
            Console.WriteLine(count);
        }

        public static int numIslands(char[][] grid)
        {
            int count = 0;
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {

                        dfs(grid, m, n, i, j);
                        count++;
                    }
                }
            }

            return count;
        }

        private static void dfs(char[][] grid, int m, int n, int i, int j)
        {
            if(i < 0 || j < 0 || i > m-1 || j > n-1 || grid[i][j] == '0')
                return;

            grid[i][j] = '0';

            dfs(grid, m, n, i + 1, j);
            dfs(grid, m, n, i - 1, j);
            dfs(grid, m, n, i, j + 1);
            dfs(grid, m, n, i, j - 1);
        }
    }
}