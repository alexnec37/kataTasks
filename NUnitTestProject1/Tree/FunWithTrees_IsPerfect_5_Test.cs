using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Tree.FunWithTrees_IsPerfect_5
{
    [TestFixture]
    class FunWithTrees_IsPerfect_5_Test
    {
        /**
        * null
        */
        [Test]
        public void NullTreeShouldBePerfect()
        {
            TreeNode root = null;
            Assert.AreEqual(true, TreeNode.IsPerfect(root), "null tree should be perfect");
        }

        /**
         *   0
         *  / \
         * 0   0
         */
        [Test]
        public void FullOneLevelTreeShouldBePerfect()
        {
            TreeNode root = TreeNode.Leaf().WithLeaves();
            Assert.AreEqual(true, TreeNode.IsPerfect(root), "root with two leaves should be perfect");
        }

        /**
         *   0
         *  /
         * 0
         */
        [Test]
        public void OneChildTreeShouldNotBePerfect()
        {
            TreeNode root = TreeNode.Leaf().WithLeftLeaf();
            Assert.AreEqual(false, TreeNode.IsPerfect(root), "root with single leaf should not be perfect");
        }

    //    /**
    //    *         0
    //    *        /
    //    *       0
    //    *      /
    //    *     0
    //    *    /
    //    *   0
    //    */
    //    [Test]
    //    public void FullUnbalancedTreeShouldNotBePerfect()
    //    {
    //        TreeNode root = TreeNode.Leaf().WithLeftLeaf()
    //            .WithLeftLeaf().WithLeftLeaf().WithLeftLeaf();

    //        Assert.AreEqual(false, TreeNode.IsPerfect(root), "root with single leaf should not be perfect");
    //    }
    }
}
