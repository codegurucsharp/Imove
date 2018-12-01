using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class DPAlgos
    {
        public bool IsUgly(int num)
        {
            int[] primes = new int[] { 2, 3, 5 };

            int result = num;
            foreach (var item in primes)
            {
                while (result % item == 0 && result / item >= 1)
                {
                    result = result / item;
                }
            }

            return result == 1;
        }

        public int kthUglyNbr(int kth)
        {
            int i = 0, j = 0, k = 0;

            int[] uglyNbrs = new int[kth];
            uglyNbrs[0] = 1;

            for (int count = 1; count < kth; count++)
            {
                int iNbr = uglyNbrs[i] * 2;
                int jNbr = uglyNbrs[j] * 3;
                int kNbr = uglyNbrs[k] * 5;

                int min = Math.Min(iNbr, Math.Min(jNbr, kNbr));
                uglyNbrs[count] = min;

                if (min == iNbr) i++;
                if (min == jNbr) j++;
                if (min == kNbr) k++;
            }

            return uglyNbrs[kth - 1];
        }

        public int SuperUgly(int n, int[] primes)
        {
            int[] uglyIndex = new int[primes.Length];
            int[] multipliedValue = new int[primes.Length];
            int[] uglyNbrs = new int[n];
            uglyNbrs[0] = 1;

            for (int count = 1; count < n; count++)
            {
                for (int i = 0; i < primes.Length; i++)
                {
                    multipliedValue[i] = uglyNbrs[uglyIndex[i]] * primes[i];
                }

                int min = multipliedValue.Min();
                uglyNbrs[count] = min;

                for (int j = 0; j < multipliedValue.Length; j++)
                {
                    if (multipliedValue[j] == min)
                    {
                        uglyIndex[j] += 1;
                    }
                }
            }

            return uglyNbrs[n - 1];
        }
    }
}
