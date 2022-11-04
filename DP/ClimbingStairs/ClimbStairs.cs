using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingStairs
{
    internal static class ClimbStairs
    {
        public static int Climb(int n)
        {
            int[] lookup = new int[n + 1];
            Array.Fill(lookup, 0);
            lookup[0] = 1;
            lookup[1] = 1;

            for(int i = 2; i <= n; i++)
            {
                ClimbHelper(i, lookup);
            }
            return lookup[n];
        }

        private static int ClimbHelper(int i, int[] lookup)
        {
            if (i == 0 || i == 1)
                return lookup[i];
            if (lookup[i] != 0)
                return lookup[i];
            lookup[i] = ClimbHelper(i - 1, lookup) + ClimbHelper(i - 2, lookup);
            return lookup[i];
        }

        public static int Climb2(int n)
        {
            int[] lookup = new int[n + 1];
            Array.Fill(lookup, 0);
            lookup[0] = 1;
            lookup[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                lookup[i] = lookup[i - 1] + lookup[i - 2];
            }

            return lookup[n];
        }
    }
}
