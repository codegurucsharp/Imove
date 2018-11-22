using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LuckyNumber
    {
        public bool IsLuckyRec(int number, int count)
        {
            if (number < count)
                return true;

            // If it's perfectly divisible that means that it will be removed in this round
            if (number % count == 0) return false;
            number -= number / count;
            count++;
            return IsLuckyRec(number, count);
        }

        public bool IsLucky(int number)
        {
            int i = 2;
            while (i <= number)
            {
                if (number % i == 0) return false;
                number -= number / i;
                i++;
            }

            return true;
        }
    }
}
