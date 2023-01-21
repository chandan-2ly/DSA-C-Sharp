using System.Text;

namespace WordSearch
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            int m = board.Length;
            int n = board[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dfs(board, i, j, word, 0, m, n))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool dfs(char[][] board, int i, int j, string word, int k, int m, int n)
        {
            if (k == word.Length)
                return true;
            if (i < 0 || i == m || j < 0 || j == n || board[i][j] != word[k])
            {
                return false;
            }

            board[i][j] = '*';

            bool result = dfs(board, i - 1, j, word, k + 1, m, n)
                    || dfs(board, i + 1, j, word, k + 1, m, n)
                    || dfs(board, i, j + 1, word, k + 1, m, n)
                    || dfs(board, i, j - 1, word, k + 1, m, n);
            board[i][j] = word[k];
            return result;

        }
    }
}
