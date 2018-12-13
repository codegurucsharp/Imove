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


        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder.Length != postorder.Length) return null;

            return BuildTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
        }

        public TreeNode BuildTree(int[] inorder, int startI, int endI, int[] postorder, int startP, int endP)
        {
            if (endP < startP) return null;
            TreeNode root = new TreeNode { Data = postorder[endP] };
            int rootVal = postorder[endP];

            int idx = 0;
            for (int i = startI; i <= endI; i++)
            {
                if (inorder[i] == rootVal)
                {
                    idx = i;
                    break;
                }
            }

            int len = idx - startI;

            root.LeftNode = BuildTree(inorder, startI, startI + idx - 1, postorder, startP + idx + 1, endP);
            root.RightNode = BuildTree(inorder, idx + 1, endI, postorder, startP + +idx + 1, endP);
            return root;
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

        public IList<int> POTraversalRecursive(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            TreeNode node = root;
            stk.Push(node);

            while (stk.Count > 0 && node != null)
            {
                if (node.LeftNode != null) stk.Push(node.LeftNode);
                if (node.RightNode != null) stk.Push(node.RightNode);
                traversal.Add(stk.Pop().Data);
            }

            return traversal;
        }
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            return HasPathSum(root, sum, root.LeftNode == null && root.RightNode == null);
        }

        public bool HasPathSum(TreeNode root, int sum, bool isleaf)
        {
            if (root == null && sum == 0 && isleaf) return true;
            if (root == null && sum != 0) return false;
            if (root == null && sum == 0 && !isleaf) return false;

            return HasPathSum(root.LeftNode, sum - root.Data, root.LeftNode == null && root.RightNode == null)
                || HasPathSum(root.RightNode, sum - root.Data, root.LeftNode == null && root.RightNode == null);
        }
    }
}