using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Tree
{
    using NUnit.Framework;
    using System;
    using codewars.Tree.FunWithTrees_MaxSum_6n;

    [TestFixture]
    public class FunWithTrees_MaxSum_6_Test
    {
        /**
         * null
         */
        [Test]
        public void MaxSumInNullTree()
        {
            TreeNode root = null;
            Assert.AreEqual(0, FunWithTrees_MaxSum_6.MaxSum(root));
        }

        /**
         *      5
         *    /   \
         *  -22    11
         *  / \    / \
         * 9  50  9   2
         */
        [Test]
        public void MaxSumInPerfectTree()
        {
            //TreeNode left = TreeNode.Leaf(-22).WithLeaves(9, 50);
            //TreeNode right = TreeNode.Leaf(11).WithLeaves(9, 2);
            //TreeNode root = TreeNode.Join(5, left, right);

            TreeNode root = new TreeNode
            {
                value = 5,
                left = new TreeNode
                {
                    value = -22,
                    left = new TreeNode { value = 9 },
                    right = new TreeNode { value = 50 }
                },
                right = new TreeNode
                {
                    value = 11,
                    left = new TreeNode { value = 9 },
                    right = new TreeNode { value = 2 }
                }
            };
            Assert.AreEqual(33, FunWithTrees_MaxSum_6.MaxSum(root));
        }
    }
}
