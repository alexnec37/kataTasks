using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars.Tree.FunWithTrees_MaxSum_6n
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int value;
    }

    public class FunWithTrees_MaxSum_6
    {
        static IList<IList<int>> sumList;
        public static int MaxSum(TreeNode root)
        {
            sumList = new List<IList<int>>();

            preOrder(root, new List<int>());

            int max = sumList.Select(x => x.Sum()).Max();
            return max;
        }

        private static void preOrder(TreeNode node, IList<int> path)
        {
            if (node == null)
            {
                sumList.Add(path);
                return;
            }

            var curPath = new List<int>(path);
            curPath.Add(node.value);
            preOrder(node.left, curPath);
            preOrder(node.right, curPath);
        }
    }
}
