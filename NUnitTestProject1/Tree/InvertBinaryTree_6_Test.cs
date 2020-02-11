using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using codewars.Tree.InvertBinaryTree_6;

namespace NUnitTestProject1.Tree
{
    [TestFixture]
    public class InvertBinaryTree_6_Test
    {
        [Test]
        public void TestFromExample()
        {
            TreeNode root1 = new TreeNode
            {
                Value = 4,
                Left = new TreeNode
                {
                    Value = 2,
                    Left = new TreeNode { Value = 1 },
                    Right = new TreeNode { Value = 3 }
                },
                Right = new TreeNode
                {
                    Value = 7,
                    Left = new TreeNode { Value = 6 },
                    Right = new TreeNode { Value = 9 }
                }
            };

            TreeNode root2 = new TreeNode
            {
                Value = 4,
                Left = new TreeNode
                {
                    Value = 7,
                    Left = new TreeNode { Value = 9 },
                    Right = new TreeNode { Value = 6 }
                },
                Right = new TreeNode
                {
                    Value = 2,
                    Left = new TreeNode { Value = 3 },
                    Right = new TreeNode { Value = 1 }
                }
            };

            CompareTrees(InvertBinaryTree_6.InvertTree(root1), root2);
        }

        private static void CompareTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return;

            Assert.False(root1 == null && root2 != null);
            Assert.False(root1 != null && root2 == null);
            Assert.AreEqual(root1.Value, root2.Value);

            CompareTrees(root1.Left, root2.Left);
            CompareTrees(root1.Right, root2.Right);
        }

    }
}
