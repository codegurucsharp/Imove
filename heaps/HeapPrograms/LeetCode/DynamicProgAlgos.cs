using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DynamicProgAlgos
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            int r1 = nums[0];
            int r2 = Math.Max(nums[2], nums[0]);
            int temp;
            for (int i = 2; i < nums.Length; i++)
            {
                temp = r2;
                r2 = Math.Max(r1 + nums[i], r2);
                r1 = temp;
                Console.WriteLine("r1=" + r1 + "r2=" + r2);
            }
            return Math.Max(r2, r1);
        }

        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length < 2) return cost[cost.Length - 1];
            int f1 = cost[0];
            int f2 = cost[1];
            int temp;
            for (int i = 2; i < cost.Length; i++)
            {
                temp = f2;
                f2 = cost[i] + Math.Min(f1, f2);
                f1 = temp;
            }

            return f2;
        }

        Dictionary<int, int> dict = new Dictionary<int, int>() { { 1, 1 }, { 2, 2 } };

        public int ClimbStairs(int n)
        {
            if (n < 3) return n;
            int[] arr = new int[n + 1];
            arr[1] = 1;
            arr[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }

        public int ClimbStairs2(int n)
        {
            if (n < 3) return n;
            int left;
            if (dict.ContainsKey(n - 1))
            {
                left = dict[n - 1];
            }
            else
            {
                left = ClimbStairs(n - 1);
            }
            int right;
            if (dict.ContainsKey(n - 2))
            {
                right = dict[n - 2];
            }
            else
            {
                right = ClimbStairs(n - 2);
            }

            var sum = left + right;
            dict[n] = sum;
            return sum;
        }

        public bool StoneGame(int[] piles)
        {
            int alex = 0;
            int lee = 0;
            int i = 0, j = piles.Length - 1;
            bool alexTurn = true;
            while (i < j)
            {
                if (alexTurn)
                {
                    if (piles[i] > piles[j])
                    {
                        alex += piles[i];
                        i++;
                    }
                    else
                    {
                        alex += piles[j];
                        j--;
                    }
                    alexTurn = false;
                }
                else
                {
                    if (piles[i] > piles[j])
                    {
                        lee += piles[i];
                        i++;
                    }
                    else
                    {
                        lee += piles[j];
                        j--;
                    }
                    alexTurn = false;
                }
            }

            return alex > lee;
        }

        /// <summary>
        /// Longest increase subsequence
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LengthOfLIS(int[] nums)
        {
            int[] lis = new int[nums.Length];

            // Initialize all to 1, as 1 is the minimum
            for (int i = 0; i < lis.Length; i++)
            {
                lis[i] = 1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j] && lis[j] >= lis[i])
                    {
                        lis[i] = lis[j] + 1;
                    }
                }
            }

            int max = 1;
            foreach (var item in lis)
            {
                if (item > max) max = item;
            }

            return max;
        }

        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i], map.GetValueOrDefault(nums[i] + 1));
                if (map.ContainsKey(nums[i] + 1))
                    res = Math.Max(res, map[nums[i]] + map[nums[i] + 1]);
                if (map.ContainsKey(nums[i] - 1))
                    res = Math.Max(res, map[nums[i]] + map[nums[i] - 1]);
            }

            return res;
        }
        public int LongestDecreasingSubsequence(int[] nums)
        {
            int[] arr = new int[nums.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] <= arr[j] && nums[i] < nums[j])
                    {
                        arr[i] = arr[j] + 1;
                    }
                }
            }

            int max = 0;
            foreach (var item in arr)
            {
                if (max < item) max = item;
            }

            return max;
        }

        Dictionary<TreeNode, int> dictionary = new Dictionary<TreeNode, int>();
        public int LargestIndependentSumSet(TreeNode tree)
        {
            if (tree == null) return 0;

            if (tree.LeftNode == null && tree.RightNode == null)
            {
                dictionary[tree] = tree.Data;
                return tree.Data;
            }

            int listExcludingcurrent = LargestIndependentSumSet(tree.LeftNode) + LargestIndependentSumSet(tree.RightNode);

            int listIncludingCurrent = tree.Data;
            if (tree.LeftNode != null)
            {
                listIncludingCurrent += LargestIndependentSumSet(tree.LeftNode.LeftNode) + LargestIndependentSumSet(tree.LeftNode.RightNode);
            }

            if (tree.RightNode != null)
            {
                listIncludingCurrent += LargestIndependentSumSet(tree.RightNode.LeftNode) + LargestIndependentSumSet(tree.RightNode.RightNode);
            }

            int max = Math.Max(listExcludingcurrent, listIncludingCurrent);
            dictionary[tree] = max;

            return max;

        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            Dictionary<TreeNode, bool> lastInLevel = new Dictionary<TreeNode, bool>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            IList<int> op = new List<int>();
            IList<IList<int>> traversal = new List<IList<int>>();
            TreeNode lastNodeInLevel = root;
            while (q.Count > 0)
            {
                int levelCount = q.Count;

                while (levelCount > 0)
                {
                    var currentNode = q.Dequeue();
                    op.Add(currentNode.Data);

                    if(currentNode.LeftNode!=null)
                    {
                        q.Enqueue(currentNode.LeftNode);
                    }

                    if(currentNode.RightNode!=null)
                    {
                        q.Enqueue(currentNode.RightNode);
                    }

                    levelCount--;
                }
                traversal.Add(op);
            }
            return traversal;
        }

        public int LargestIndependentSet(TreeNode root)
        {
            if (root == null) return 0;

            if (root.LeftNode == null && root.RightNode == null) return 1;

            int excludingRoot = LargestIndependentSet(root.LeftNode) + LargestIndependentSet(root.RightNode);
            int includingRoot = 1;
            Queue<int> q;

            if (root.LeftNode != null)
                includingRoot += LargestIndependentSet(root.LeftNode.LeftNode) + LargestIndependentSet(root.LeftNode.RightNode);

            if (root.RightNode != null)
                includingRoot += LargestIndependentSet(root.RightNode.LeftNode) + LargestIndependentSet(root.RightNode.RightNode);

            return Math.Max(excludingRoot, includingRoot);
        }
    }

    public class NumArray
    {
        private int[] sumArray;
        public NumArray(int[] nums)
        {
            sumArray = new int[nums.Length + 1];
            sumArray[0] = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                sumArray[i] = sumArray[i - 1] + nums[i];
            }
        }

        public int SumRange(int i, int j)
        {
            return sumArray[j + 1] - sumArray[i];
        }
    }
}
