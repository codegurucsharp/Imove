using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsPrimeChecker
    {
        public bool IsPrimeSqRoot(int num)
        {
            for (int i = 2; i * i < num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        public bool IsPrime(int num)
        {
            bool[] arr = new bool[num + 1];

            for (int i = 2; i <= num; i++)
            {
                if (arr[i] == false)
                {
                    for (int j = 2; j * i <= num; j++)
                    {
                        arr[j * i] = true;
                    }
                }
            }

            return !arr[num];
        }
    }
}
