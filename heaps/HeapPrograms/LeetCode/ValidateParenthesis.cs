using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ValidateParenthesis
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char> { { '}', '{' }, { ']', '[' }, { ')', '(' } };

            if (s == null || s.Length == 0)
                return true;

            if (s.Length == 1) return false;

            var arr = s.ToCharArray();
            Stack<char> stk = new Stack<char>();

            foreach (var item in arr)
            {
                if (item == '}' || item == ')' || item == ']')
                {
                    if (stk.Count > 0 && keyValuePairs.ContainsKey(item) && stk.Peek() == keyValuePairs[item])
                    {
                        stk.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stk.Push(item);
                }
            }
            // int count = 0;
            ////while (arr.Length > count)
            ////{
            ////    if (arr[count] == '}' || arr[count] == ')' || arr[count] == ']')
            ////    {
            ////        if (stk.Count == 0) return false;
            ////        if (arr[count] == keyValuePairs[stk.Peek()])
            ////            stk.Pop();
            ////        else
            ////            return false;
            ////    }
            ////    else
            ////    {
            ////        stk.Push(arr[count]);
            ////    }
            ////    count++;
            ////}

            return stk.Count == 0;
        }
    }
}
