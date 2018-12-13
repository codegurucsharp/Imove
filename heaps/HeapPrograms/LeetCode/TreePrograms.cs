using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TreePrograms
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return null;
            string serialized = string.Empty;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var t = q.Dequeue();

                serialized += t == null ? "#," : t.Data + ",";
                if (t == null) continue;
                q.Enqueue(t.LeftNode);
                q.Enqueue(t.RightNode);
            }

            return serialized.TrimEnd(',');
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;
            var arr = data.Split(",");

            int i = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            TreeNode root = new TreeNode { Data = int.Parse(arr[i]) };
            q.Enqueue(root);
            TreeNode node = root;
            TreeNode left = null;
            TreeNode right = null;

            while (q.Count > 0 && i + 1 < arr.Length)
            {
                var dq = q.Dequeue();
                left = arr[i + 1] == "#" ? null : new TreeNode { Data = int.Parse(arr[i + 1]) };
                right = i+2 == arr.Length || arr[i + 2] == "#" ? null : new TreeNode { Data = int.Parse(arr[i + 2]) };
                if (dq != null)
                {
                    dq.LeftNode = left;
                    dq.RightNode = right;

                    q.Enqueue(left);
                    q.Enqueue(right);
                    i += 2;
                }
            }

            return root;
        }

        public int SizeOfTree(TreeNode treeNode)
        {
            return treeNode == null ? 0 : 1 + SizeOfTree(treeNode.LeftNode) + SizeOfTree(treeNode.RightNode);
        }

        public TreeNode MirrorTree(TreeNode node)
        {
            if (node != null)
            {
                MirrorTree(node.LeftNode);
                MirrorTree(node.RightNode);
                var tmp = node.LeftNode;
                node.LeftNode = node.RightNode;
                node.RightNode = tmp;
            }
            return node;
        }

        public int diameter(TreeNode root, int maxDia)
        {
            if (root == null) return 0;
            int lheight, rheight, ldia, rdia;
            lheight = Height(root.LeftNode);
            rheight = Height(root.RightNode);
            ldia = diameter(root.LeftNode, maxDia);
            rdia = diameter(root.RightNode, maxDia);

            return Math.Max(ldia, Math.Max(rdia, lheight + rheight + 1));
            // Anvay Password: 2018Sn#1064748
        }

        int maxDiagTillNow = 0;

        public int diameterOnlyUsingHeight(TreeNode root)
        {
            if (root == null) return 0;
            int lheight, rheight;
            lheight = Height(root.LeftNode);
            rheight = Height(root.RightNode);

            return Math.Max(maxDiagTillNow, lheight + rheight + 1);
        }

        public int Height(TreeNode tree)
        {
            if (tree == null) return 0;
            if (tree.LeftNode == null && tree.RightNode == null) return 1;
            return Math.Max(Height(tree.LeftNode), Height(tree.RightNode)) + 1;

        }

    }
}
