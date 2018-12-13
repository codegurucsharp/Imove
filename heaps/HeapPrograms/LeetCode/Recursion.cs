using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Recursion
    {
        int max = 0;
        public int LongestUnivaluePath(TreeNode root)
        {
            if (root == null) return 0;
            CountLength(root);
            return max;
        }

        private int CountLength(TreeNode root)
        {
            if (root == null) return 0;
            int left = CountLength(root.LeftNode);
            int right = CountLength(root.RightNode);
            if (root.LeftNode != null && root.LeftNode.Data == root.Data)
                left++;

            if (root.RightNode != null && root.RightNode.Data == root.Data)
                right++;

            max = Math.Max(max, left + right);

            return Math.Max(left, right);


        }
    }
}
