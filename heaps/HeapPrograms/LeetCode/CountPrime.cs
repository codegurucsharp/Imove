using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class CountPrime
    {

        public int CountPrimesFast(int n)
        {
            int countOfPrimes = 0;
            bool[] primes = new bool[n + 1];

            for (int i = 2; i < n; i++)
            {
                if (primes[i] == false)
                {
                    countOfPrimes++;
                    for (int j = 2; i * j <= n; j++)
                    {
                        primes[i * j] = true;
                    }
                }
            }

            return countOfPrimes;
        }

        public int CountPrimes(int n)
        {
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                count = IsPrimeSqRoot(i) ? count + 1 : count;
            }

            return count;
        }

        public bool IsPrimeSqRoot(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
