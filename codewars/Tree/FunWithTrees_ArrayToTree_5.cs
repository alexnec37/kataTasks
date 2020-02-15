using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Tree.FunWithTrees_ArrayToTree_5
{
    public class TreeNode
    {

        public TreeNode left;
        public TreeNode right;
        public int value;

        public TreeNode(int value, TreeNode left, TreeNode right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public TreeNode(int value)
        {
            this.value = value;
        }
    }

    public class FunWithTrees_ArrayToTree_5
    {
        static int[] arrayTree;
        static TreeNode tree;
        public static TreeNode ArrayToTree(int[] array)
        {
            tree = null;
            arrayTree = array;
            nodeByIndex(ref tree, 0);
            return tree;
        }

        static void nodeByIndex(ref TreeNode node, int index)
        {
            if (index > arrayTree.Length - 1)
            {
                return;
            }
            
            node = new TreeNode(arrayTree[index]);
            nodeByIndex(ref node.left, 2 * index + 1);
            nodeByIndex(ref node.right, 2 * index + 2);
        }
    }
}
