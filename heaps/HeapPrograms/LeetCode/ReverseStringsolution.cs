using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ReverseStringSolution
    {
        public static string ReverseString(string s)
        {
            var arr = s.ToCharArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                char tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }

            return string.Join("", arr);
        }
    }
}