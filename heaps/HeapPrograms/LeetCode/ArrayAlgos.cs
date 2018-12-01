using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LeetCode
{
    public class ArrayAlgos
    {
        public void FindAPairWhoseSumIsX(int[] arr, int X)
        {
            int left = 0;
            int right = arr.Length - 1;
            arr = arr.OrderBy(i => i).ToArray();
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == X)
                {
                    Console.WriteLine("Found:" + arr[left] + "+" + arr[right]);
                    left++;
                }
                if (sum > X) right--;
                if (sum < X) left++;
            }
        }

        public void FindAPairWhoseSumIsXWithoutSorting(int[] arr, int X)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int lookfor = X - arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == lookfor)
                        Console.WriteLine("Found");
                }
            }
        }

        public int[] Add1(int[] numArray)
        {
            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                if (numArray[i] < 9)
                {
                    numArray[i]++;
                    return numArray;
                }
                numArray[i] = 0;
            }

            var newArr = new int[numArray.Length + 1];
            newArr[0] = 1;
            return newArr;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            // Only show unique solutions
            List<IList<int>> solutionSet = new List<IList<int>>();
            IList<int> solution = new List<int>();
            int target = 0;
            nums = nums.OrderBy(i => i).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i > 0) && (nums[i] == nums[i - 1]))
                    continue;

                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum < target)
                    {
                        left++;
                    }
                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        solution = new List<int>();
                        solution.Add(nums[i]);
                        solution.Add(nums[left]);
                        solution.Add(nums[right]);
                        solutionSet.Add(solution);
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (right > left && nums[right] == nums[right - 1]) right--;
                        left++;
                    }
                }
            }

            return solutionSet;
        }

        public void FindMajorityElement(int[] n)
        {
            int midSize = n.Length / 2;
            n = n.OrderBy(i => i).ToArray();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == n[i + midSize]) Console.WriteLine("Majority element: " + n[i]);
            }

            Console.WriteLine("Not found");
        }

        public void FindMajorityElementMoore(int[] n)
        {
            int votes = 1;
            int majorityIndex = 0;

            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] == n[majorityIndex]) votes++;
                else votes--;

                if (votes == 0)
                {
                    majorityIndex = i;
                    votes++;
                }
            }

            Console.WriteLine(n[majorityIndex]);
        }

        public int MaxSumSubArray(int[] nums)
        {
            int newNo = nums[0];
            int currentMax = newNo = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                newNo = newNo > 0 ? newNo + nums[i] : nums[i];
                currentMax = Math.Max(newNo, currentMax);
            }

            return currentMax;
        }

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] == 0)
                {
                    max = Math.Max(sum, max);
                    sum = 0;
                }
            }

            return Math.Max(sum, max);
        }

        // This only works for the Positive Numbers
        public int SubarraySum(int[] nums, int k)
        {
            int leftptr = 0;
            int rightptr = 1;
            int sum = 0;
            int subarraysFound = 0;
            if (nums[0] == k) subarraysFound++;
            while (leftptr <= rightptr && rightptr < nums.Length)
            {
                sum = 0;

                if (leftptr == rightptr && nums[leftptr] == k)
                {
                    subarraysFound++;
                    rightptr++;
                    continue;
                }

                for (int i = leftptr; i <= rightptr; i++)
                {
                    sum += nums[i];
                }

                if (sum < k)
                {
                    // Include one more number
                    rightptr++;
                }
                else if (sum > k)
                {
                    // Decrease one number, by moving the left pointer
                    leftptr++;
                }
                else
                {
                    subarraysFound++;
                    // Here you can move any of the pointer as now we want to move on to find the next one.
                    rightptr++;
                }
            }

            return subarraysFound;
        }

        // This one works with NegativeNos too
        public int SubarraySumGeneric(int[] nums, int k)
        {
            Dictionary<int, int> hashset = new Dictionary<int, int>();
            hashset.Add(0, 1);

            int sumTillNow = 0;
            int diff = 0;
            int subarrays = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sumTillNow += nums[i];
                diff = sumTillNow - k;
                if (hashset.ContainsKey(diff))
                {
                    subarrays = subarrays + hashset[diff];
                }
                if (hashset.ContainsKey(sumTillNow))
                {
                    hashset[sumTillNow] += 1;
                }
                else
                {
                    hashset[sumTillNow] = 1;
                }
            }

            return subarrays;
        }

        public int SubarraySumFromLeetCodeSols(int[] nums, int k)
        {
            int count = 0, sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            map.Add(0, 1); // this is to handle the case of 0 expected as sum and only one element in the array and same element exepected as sum
            int diff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                diff = sum - k;
                if (map.ContainsKey(diff))
                    count += map[diff];
                map[sum] = map.GetValueOrDefault(sum, 0) + 1;
            }
            return count;
        }

        public int SubarraySumBest(int[] nums, int k)
        {
            Dictionary<int, int> subtotals = new Dictionary<int, int>();    //key: subtotalamount, value: number of occurance
            int runningsum = 0;
            int ret = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                runningsum += nums[i];

                int gap = runningsum - k;
                if (gap == 0) // this is to handle the case of 0 expected as sum and only one element in the array and same element exepected as sum
                    ret++;

                if (subtotals.ContainsKey(gap))
                    ret += subtotals[gap];

                if (subtotals.ContainsKey(runningsum))
                    subtotals[runningsum]++;
                else
                    subtotals.Add(runningsum, 1);
            }

            return ret;
        }

        public void FindLargestSubArrary(int[] arr)
        {
            // This is only for 1 / 0 array.
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            int lower = 0;
            int higher = 0;
            int length = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) arr[i] = -1;
            }

            int runningSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                runningSum += arr[i];
                if (pairs.ContainsKey(runningSum))
                {
                    if (length <= i - pairs[runningSum])
                    {
                        lower = pairs[runningSum];
                        higher = i;
                        length = higher - lower + 1;
                    }
                }
                else
                {
                    pairs[runningSum] = i;
                }
            }

            Console.WriteLine("Length = " + length);
        }

        public int MaxProfit(int[] prices)
        {
            int runningMin = prices[0];
            int runningDiff = 0;
            int currentDiff = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < runningMin)
                {
                    runningMin = prices[i];
                }
                else
                {
                    currentDiff = prices[i] - runningMin;
                    if (currentDiff > runningDiff)
                    {
                        runningDiff = currentDiff;
                    }
                }
            }

            return runningDiff;
        }

        public int MaxProfitMultipleTransactions(int[] prices)
        {
            int runningMin = prices[0];
            int runningDiff = 0;
            int currentDiff = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < runningMin)
                {
                    runningMin = prices[i];
                }
                else
                {
                    currentDiff = prices[i] - runningMin;
                    if (currentDiff > runningDiff)
                    {
                        runningDiff = currentDiff;
                    }
                }
            }

            return runningDiff;
        }

        public int NumJewelsInStones(string J, string S)
        {
            // Input: J = "aA", S = "aAAbbbb"
            // Output: 3
            char[] myStones = S.ToCharArray();
            int i = 0;
            int count = 0;
            char[] jewels = J.ToCharArray();

            while (i < myStones.Length)
            {
                if (jewels.Contains(myStones[i]))
                    count++;
                i++;
            }
            return count;
        }
    }
}
