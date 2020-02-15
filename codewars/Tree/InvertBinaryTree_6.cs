using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace codewars.Tree.InvertBinaryTree_6
{
    public class InvertBinaryTree_6
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            preOrder(root);
            return root;
        }

        private static void preOrder(TreeNode node)
        {
            if (node == null) return;
            swap(node);
            preOrder(node.Left);
            preOrder(node.Right);
        }

        private static void swap(TreeNode node)
        {
            var temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }
    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}
