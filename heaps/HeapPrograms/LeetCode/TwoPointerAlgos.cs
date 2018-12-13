using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class TwoPointerAlgos
    {
        public bool IsLongPressedName(string name, string typed)
        {
            char current = name[0];
            int i = 0, j = 0;

            while (i < name.Length)
            {
                if (j == typed.Length) return false;

                if (name[i] == typed[j])
                {
                    current = name[i];
                    i++; j++;
                }
                else if (typed[j] == current)
                {
                    while (j < typed.Length && typed[j] == current)
                    {
                        j++;
                    }
                }
                else
                    return false;
            }

            while (j < typed.Length && typed[j] == current)
            {
                j++;
            }

            if (j == typed.Length)
                return true;
            return false;
        }

        public bool BackspaceCompareUsingStk(string S, string T)
        {
            var lStack = Build(S);
            var rStack = Build(T);

            if (lStack.Count == rStack.Count)
            {
                while (lStack.Count > 0)
                {
                    if (lStack.Pop() != rStack.Pop())
                        return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private Stack<char> Build(string str)
        {
            Stack<char> stk = new Stack<char>();
            foreach (var item in str)
            {
                if (item != '#')
                    stk.Push(item);
                else if (stk.Count > 0)
                    stk.Pop();
            }

            return stk;
        }
        public bool BackspaceCompare(string S, string T)
        {
            var op1 = new char[S.Length];
            var op2 = new char[T.Length];

            int i = 0;
            int j = 0;
            int ctrT = 0;
            int ctrS = 0;

            while (ctrS < S.Length || ctrT < T.Length)
            {
                if (ctrS < S.Length)
                {
                    if (S[ctrS] == '#') i = i > 0 ? i - 1 : i;
                    else
                        op1[i++] = S[ctrS];
                }
                if (ctrT < T.Length)
                {
                    if (T[ctrT] == '#') j = j > 0 ? j - 1 : j;
                    else
                        op2[j++] = T[ctrT];
                }
                ctrS++; ctrT++;
            }
            if (i != j) return false;
            i--;
            while (i >= 0)
            {
                if (op1[i] == op2[i]) i--;
                else return false;
            }
            return true;

        }

        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return nums[i];
            }
            

            return -1;
        }

        public int FindDuplicateUsingArrayIndices(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i])] > 0)
                    nums[Math.Abs(nums[i])] = -nums[Math.Abs(nums[i])];
                else return Math.Abs(nums[i]);
            }

            return -1;
        }
    }
}
