using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class KthSmallestInBinTree
    {
        public int KthSmallest2(TreeNode root, int k)
        {
            
            
            return traverse(root).ElementAt(k-1);
        }
        IEnumerable<int> traverse(TreeNode r)
        {
            if (r != null)
            {
                foreach (var item in traverse(r.LeftNode)) yield return item;
                yield return r.Data;
                foreach (var item in traverse(r.RightNode)) yield return item;
            }
        }
        int count = 0;
        public int KthSmallest(TreeNode root, int k)
        {
            var t = Inorder(root, k);

            if (t != null)
            {
                Console.WriteLine("Res="+t.Data);
                return t.Data;
            }
            else
            {
                Console.WriteLine("t was null");
            }
            return -1;
        }

        private TreeNode Inorder(TreeNode treeNode, int k)
        {
            if (treeNode != null)
            {
                Inorder(treeNode.LeftNode, k);
                count++;
                if (k == count)
                {
                    Console.WriteLine("count matching" + treeNode.Data);
                    return treeNode;
                }

                Inorder(treeNode.RightNode, k);
            }

            return treeNode;
        }
    }
}
