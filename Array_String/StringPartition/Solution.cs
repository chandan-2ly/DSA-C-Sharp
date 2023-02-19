namespace StringPartition
{
    public class Solution
    {
        public IList<IList<string>> Partition(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;

            IList<IList<string>> result = new List<IList<string>>();
            IList<string> current = new List<string>();

            if (s.Length == 1)
            {
                result.Add(new List<string> { s });
                return result;
            }

            PartitionHelper(s, 0, current, result);

            return result;
        }

        private void PartitionHelper(string s, int index, IList<string> current, IList<IList<string>> result)
        {
            if (index == s.Length)
            {
                result.Add(new List<string>(current));
                return;
            }

            for (int i = index; i < s.Length; i++)
            {
                if (IsPallindrome(s, index, i))
                {
                    current.Add(s.Substring(index, i - index + 1));
                    PartitionHelper(s, i + 1, current, result);
                    current.RemoveAt(current.Count - 1);
                }
            }

            return;
        }

        private bool IsPallindrome(string str, int start, int end)
        {
            while (start < end)
            {
                if (str[start] != str[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }
    }
}

