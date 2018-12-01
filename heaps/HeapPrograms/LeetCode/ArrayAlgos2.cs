using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class ArrayAlgos2
    {
        public int[] NextGreaterElementPart1(int[] findNums, int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Stack<int> stk = new Stack<int>();
            foreach (var item in nums)
            {
                while (stk.Count != 0 && stk.Peek() < item)
                    map[stk.Pop()] = item;
                stk.Push(item);
            }
            for (int i = 0; i < findNums.Length; i++)
            {
                findNums[i] = map.ContainsKey(findNums[i]) ? map[findNums[i]] : -1;
            }
            return findNums;
        }

        public int maxProductOf3Nos(int[] nos)
        {
            nos = nos.OrderBy(i => i).ToArray();
            int left = nos[0] * nos[1] * nos[nos.Length - 1];
            int right = nos[nos.Length - 3] * nos[nos.Length - 2] * nos[nos.Length - 1];
            if (left > right) return left;
            return right;
        }
        public int NextGreaterElement(int n)
        {
            char[] nstr = n.ToString().ToCharArray();
            int[] arr = new int[nstr.Length];
            int[] nextg = new int[nstr.Length];

            for (int i = 0; i < nstr.Length; i++)
            {
                arr[i] = int.Parse(nstr[i].ToString());
            }

            Stack<int> nextGreater = new Stack<int>();
            int lastIndexToExchange = -1;
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (nextGreater.Count == 0 || arr[i] < arr[nextGreater.Peek()])
                {
                    nextGreater.Push(i);
                }
                else if (arr[i] > arr[nextGreater.Peek()])
                {
                    int nextgreaterno = nextGreater.Pop();
                    Console.WriteLine("Next greater for:" + arr[nextgreaterno] + "=" + arr[i]);
                    nextg[j] = i;
                    lastIndexToExchange = i;
                    i--;
                    j++;
                }
            }

            while (nextGreater.Count > 0)
            {
                nextg[j] = -1;
                nextGreater.Pop();
                j++;
            }

            // swap
            bool found = false;

            for (int i = nextg.Length - 1; i >= 0; i--)
            {
                if (nextg[i] > 0)
                {
                    int tmp = arr[i];
                    arr[i] = arr[nextg[i]];
                    arr[nextg[i]] = tmp;
                    found = true;
                    break;
                }
            }

            var t = int.MaxValue;
            var res = found ? int.Parse(string.Join("", arr)) : -1;

            return res;
        }

        public int ThirdMaxNumber(int[] nums)
        {
            long max = long.MinValue;
            long secondMax = long.MinValue;
            long thirdMax = long.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                // ignore number if the nbr is any of first, second or third max
                if (nums[i] == max || nums[i] == secondMax || nums[i] == thirdMax) continue;

                if (nums[i] > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = nums[i];
                }
                else if (nums[i] > secondMax)
                {
                    thirdMax = secondMax;
                    secondMax = nums[i];
                }
                else if (nums[i] > thirdMax)
                {
                    thirdMax = nums[i];
                }
            }

            return thirdMax != long.MinValue ? (int)thirdMax : (int)max;
        }
    }
}

