using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
    }

    public class TreeTraversal
    {
        Queue<TreeNode> q = new Queue<TreeNode>();

        public void LevelOrderTraversalRecursive(TreeNode treeNode)
        {
            if (treeNode == null)
                return;
            Console.WriteLine(treeNode.Data);
            q.Enqueue(treeNode.LeftNode);
            q.Enqueue(treeNode.RightNode);

            LevelOrderTraversalRecursive(q.Dequeue());
        }

        public void LevelOrderTraversal(TreeNode treeNode)
        {
            if (treeNode == null)
                return;
            int count = 0;
            var node = treeNode;
            q.Enqueue(node);
            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.WriteLine($"Level:{count}: {node.Data}");
                if (node.LeftNode != null) q.Enqueue(node.LeftNode);
                if (node.RightNode != null) q.Enqueue(node.RightNode);
            }
        }

        List<int> traversal = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            POTraversal(root);
            return traversal;
        }

        private void POTraversal(TreeNode root)
        {
            if (root == null) return;

            POTraversal(root.LeftNode);
            POTraversal(root.RightNode);
            traversal.Add(root.Data);
        }
    }
}