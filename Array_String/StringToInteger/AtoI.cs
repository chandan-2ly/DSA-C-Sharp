using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger
{
    public static class AtoI
    {
        public static int MyAtoi(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            int[] sign = new int[1];
            sign[0] = 0;

            int ans = 0;
            string str = s.Trim();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' && sign[0] == 0)
                {
                    sign[0]++;
                }
                else if (str[i] == '-' && sign[0] == 0)
                {
                    sign[0]--;
                }
                else if ((str[i] == '-' || str[i] == '+') && sign[0] != 0)
                {
                    break;
                }
                else if (!(str[i] >= '0' && str[i] <= '9'))
                {
                    break;
                }
                else if (sign[0] < 0)
                    ans = ans * 10 - (str[i] - '0');
                else
                {
                    ans = ans * 10 + (str[i] - '0');
                }

                if (ans >= int.MaxValue)
                {
                    return int.MaxValue;
                }
                if (ans <= int.MinValue)
                {
                    return int.MinValue;
                }
            }
            return ans;
        }
    }
}
