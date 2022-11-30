namespace MinimumWindowSubstring
{
    internal static class MinimumWindow
    {
        public static string MinWindow(string s, string t)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int index = 0; index < t.Length; index++)
            {
                if (map.ContainsKey(t[index]))
                {
                    map[t[index]]++;
                }
                else
                    map[t[index]] = 1;
            }

            int i = 0, j = 0, min = int.MaxValue, mapSize = map.Count;
            string ans = "";

            while (j < s.Length)
            {
                if (map.ContainsKey(s[j]))
                {
                    map[s[j]]--;

                    if (map[s[j]] == 0)
                    {
                        mapSize--;
                    }
                }

                if (mapSize > 0)
                {
                    j++;
                }
                else if (mapSize == 0)
                {
                    while (mapSize == 0)
                    {
                        int len = j - i + 1;

                        if (len < min)
                        {
                            min = len;
                            ans = s.Substring(i, len);
                        }

                        if (map.ContainsKey(s[i]))
                        {
                            if (map[s[i]] == 0)
                                mapSize++;
                            map[s[i]]++;
                        }
                        i++;
                    }
                    j++;
                }
            }

            return ans;
        }
    }
}
