using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Tree.FunWithTrees_ArrayToTree_5
{
    [TestFixture]
    public class FunWithTrees_ArrayToTree_5_Test
    {
        [Test]
        public void EmptyArray()
        {
            TreeNode expected = null;
            Assert.AreEqual(expected, FunWithTrees_ArrayToTree_5.ArrayToTree(new int[] { }));
        }


        // надо реалтзовать Equable
        //[Test]
        //public void ArrayWithMultipleElements()
        //{
        //    TreeNode expected = new TreeNode(17, new TreeNode(0, new TreeNode(3), new TreeNode(15)), new TreeNode(-4));
        //    Assert.AreEqual(expected, FunWithTrees_ArrayToTree_5.ArrayToTree(new int[] { 17, 0, -4, 3, 15 }));
        //}
    }
}
