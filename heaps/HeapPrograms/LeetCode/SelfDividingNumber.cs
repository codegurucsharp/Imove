using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SelfDividingNumber
    {

        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> selfDividing = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (isSelfDividing(i))
                {
                    selfDividing.Add(i);
                }
            }

            return selfDividing;
        }

        public bool isSelfDividing(int n)
        {
            int x = n;
            while (x > 0)
            {
                int leastSignificantDigit = x - (x / 10) * 10;
                if (leastSignificantDigit == 0) return false;
                if(n % leastSignificantDigit!=0) return false;
                x = x / 10;
            }

            return true;
        }
    }
}
