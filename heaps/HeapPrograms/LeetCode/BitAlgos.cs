using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BitAlgos
    {
        public bool isPowerOf2(int n)
        {
            // Check that the log of the number is not decimal
            return Math.Floor(Math.Log(n, 2)) == Math.Ceiling(Math.Log(n, 2));
        }

        public bool isPowerOf2Approach1(int n)
        {
            // Check that the number of bits on is only 1
            return CountNumberOfBitsSetApp1(n) == 1;
        }

        public bool isPowerOf2Approach2(int n)
        {
            // The number which is power of 2 has only one bit set.
            // If you subtract one from this, all previous bit to that bit become unset
            // Now if you And the number with this number it will be Zero
            return n > 0 && (n & (n - 1)) == 0;

            // return n && (n & (n - 1)) == 0;
            // We can also do the above one as avoid doing a check of n>0
        }

        public int CountNumberOfBitsSetApp1(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if (n % 2 == 1) count++;
                n = n / 2;
            }

            return count;
        }

        public int CountNumberOfBitsSetApp2(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) > 0) count++;
                n = n >> 1;
            }

            return count;
        }

        public bool KthBitSetOrnot(int number, int k)
        {
            int andWithOnlyKthBitSet = 1 << k;

            return (number & andWithOnlyKthBitSet) == andWithOnlyKthBitSet;
        }

        public bool KthBitSetOrnotApp2(int number, int k)
        {
            // Right Shift the number by K bits, this will keep the right bit as 1, if the bit is not set then we will get Zero
            return ((number >> k) & 1) >= 0;
        }

        public int SetKthBit(int number, int k)
        {
            int OneLeftShiftedByK = 1 << k;
            return number | OneLeftShiftedByK;
        }

        public int ClearKthBit(int number, int k)
        {
            int nowithKthBitZero = ~(1 << k);
            return number & nowithKthBitZero;
        }

        public bool IsPowerOf4(int num)
        {
            if (num < 1) return false;
            return Math.Floor(Math.Log(num, 4)) == Math.Ceiling(Math.Log(num, 4));
        }

        public bool IsPowerOf4App2(int num)
        {
            int count = 0;
            // Check if only single bit was set
            if (num > 0 && (num & num - 1) == 0)
            {
                while (num > 1)
                {
                    num = num >> 1;
                    count++;
                }

                return count % 2 == 0;
            }
            return false;
        }

        public int SingleNumber(int[] nums)
        {
            int newValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                newValue = newValue ^ nums[i];
            }

            return newValue;
        }

        public int ToggleKthBit(int num, int k)
        {
            int numberWithKthBitOne = 1 << k;

            return num ^ numberWithKthBitOne;

        }

        public int getNextPowerOf2Number(int number)
        {
            // First find out which bit is the last set bit
            int count = 0;
            while (number > 0)
            {
                number = number >> 1;
                count++;
            }

            // Now move count by that many times, so it will be one higher
            return 1 << count;
        }

        public double getNextPowerOf2NumberLogApproach(int number)
        {
            int num = (int)Math.Floor(Math.Log(number, 2)) + 1;
            // Now move count by that many times, so it will be one higher
            return Math.Pow(2, num);
        }
    }
}
