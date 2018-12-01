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


        // Input: "ab-cd"
        // Output: "dc-ba"
        // Example 2:

        // Input: "a-bC-dEf-ghIj"
        // Output: "j-Ih-gfE-dCba"
        // Example 3:

        // Input: "Test1ng-Leet=code-Q!"
        // Output: "Qedo1ct-eeLg=ntse-T!"

        public string ReverseOnlyLetters(string S)
        {
            var str = S.ToCharArray();

            int leftPtr = 0;
            int rightPtr = str.Length - 1;

            while (leftPtr < rightPtr)
            {
                while (isSpecial(str[leftPtr]) && leftPtr < str.Length-1) leftPtr++;
                while (isSpecial(str[rightPtr]) && rightPtr > 0) rightPtr--;
                if (leftPtr > rightPtr) break;
                char temp = str[leftPtr];
                str[leftPtr] = str[rightPtr];
                str[rightPtr] = temp;
                leftPtr++;
                rightPtr--;

            }

            return string.Join("", str);
        }

        private bool isSpecial(char s)
        {
            if (((int)s >= 65 && (int)s <= 90) || ((int)s >= 97 && (int)s <= 122)) return false;
            return true;
        }
    }
}
