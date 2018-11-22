using System;
using System.Collections.Generic;

namespace LeetCode
{

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class NaryTraversal
    {
        List<int> traversed2 = new List<int>();
        List<int> preOrderTraversed = new List<int>();
        int maxDepth = 0;
        public IList<int> Postorder(Node root)
        {
            List<int> traversed = new List<int>();

            if (root == null) return traversed;

            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    var t = Postorder(item);
                    if (t != null)
                    {
                        traversed.AddRange(t);
                    }
                }
            }

            traversed.Add(root.val);
            return traversed;
        }

        public IList<int> Postorder2(Node root)
        {
            Traverse(root);
            return traversed2;
        }

        public void Traverse(Node root)
        {
            if (root == null) return;

            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    Traverse(item);
                }
            }
            traversed2.Add(root.val);
        }

        public IList<int> PreOrder(Node root)
        {
            PreOrderTraverse(root);
            return preOrderTraversed;
        }

        public void PreOrderTraverse(Node root)
        {
            if (root == null) return;

            preOrderTraversed.Add(root.val);

            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    PreOrderTraverse(item);
                }
            }
        }

        public int MaxDepth(Node root)
        {
            CalculateMaxDepth(root, 0);
            return maxDepth;
        }

        private void CalculateMaxDepth(Node root, int depth)
        {
            if (root == null) return;
            depth++;
            if (depth > maxDepth) maxDepth = depth;

            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    CalculateMaxDepth(item, depth);
                }
            }
        }

        public int MaxDepth2(Node root)
        {
            if (root == null) return 0;
            if (root.children == null || root.children.Count == 1) return 1;

            int max = 0;
            foreach (var item in root.children)
            {
                max = Math.Max(MaxDepth2(item), max);
            }

            return max + 1;
        }
    }
}
