using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IdenticalTreeChecker
    {
        public class Solution
        {
            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                if (p == null && q == null) return true;
                if (p == null || q == null) return false;
                return (p.Data == q.Data && IsSameTree(p.LeftNode, q.LeftNode) && IsSameTree(p.RightNode, q.RightNode)) ;
            }
        }
    }
}
