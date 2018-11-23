using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TreePrograms
    {
        public int SizeOfTree(TreeNode treeNode)
        {
            return treeNode == null?0:1 + SizeOfTree(treeNode.LeftNode) + SizeOfTree(treeNode.RightNode);
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
    }
}
