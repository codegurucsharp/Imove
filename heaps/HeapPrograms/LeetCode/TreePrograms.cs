using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TreePrograms
    {
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
