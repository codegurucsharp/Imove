using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SingleNonDuplicateSolution
    {
        public static void SingleNonDuplicate(int[] nums, int startIndex, int endIndex)
        {
            // Do like a Binary Search
            // https://www.geeksforgeeks.org/find-the-element-that-appears-once-in-a-sorted-array/
            // https://leetcode.com/problems/single-element-in-a-sorted-array/

            if (startIndex > endIndex) return;

            if (startIndex == endIndex)
            {
                Console.WriteLine(nums[startIndex]); return;
            }

            int mid = (startIndex + endIndex) / 2;

            if (mid % 2 == 0)
            {
                if (nums[mid] == nums[mid + 1])
                {
                    SingleNonDuplicate(nums, mid + 2, endIndex);
                }
                else
                {
                    SingleNonDuplicate(nums, startIndex, mid);
                }
            }
            else
            {
                if (nums[mid] == nums[mid - 1])
                {
                    SingleNonDuplicate(nums, mid + 1, endIndex);
                }
                else
                {
                    SingleNonDuplicate(nums, startIndex, mid - 1);
                }
            }
        }
    }
}
