using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class StringAlgos
    {
        public string ToLowerCase(string str)
        {
            var arr = str.ToCharArray();
            int mask = 1 << 5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 65 && arr[i] <= 90)
                {
                    arr[i] = (char)(arr[i] | mask);
                }
            }

            return new string(arr);
        }
    }
}
