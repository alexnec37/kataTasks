using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTestProject1.Tree.FunWithTrees_IsPerfect_5
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;

        public static bool IsPerfect(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int level = 1;
            var list = new List<TreeNode>(GetChildren(root));
            while(list.Count > 0)
            {
                if (list.Count > 1 && (list.Count & (list.Count - 1)) == 0 && Math.Pow(2, level) == list.Count)
                {
                    list = list.SelectMany(x => GetChildren(x)).ToList();
                    level++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static IEnumerable<TreeNode> GetChildren(TreeNode node)
        {
            if (node.left != null) yield return node.left;
            if (node.right != null) yield return node.right;
        }

        public static TreeNode Leaf()
        {
            return new TreeNode();
        }

        public static TreeNode Join(TreeNode left, TreeNode right)
        {
            return new TreeNode().WithChildren(left, right);
        }

        public TreeNode WithLeft(TreeNode left)
        {
            this.left = left;
            return this;
        }

        public TreeNode WithRight(TreeNode right)
        {
            this.right = right;
            return this;
        }

        public TreeNode WithChildren(TreeNode left, TreeNode right)
        {
            this.left = left;
            this.right = right;
            return this;
        }

        public TreeNode WithLeftLeaf()
        {
            return WithLeft(Leaf());
        }

        public TreeNode WithRightLeaf()
        {
            return WithRight(Leaf());
        }

        public TreeNode WithLeaves()
        {
            return WithChildren(Leaf(), Leaf());
        }
    }
}
