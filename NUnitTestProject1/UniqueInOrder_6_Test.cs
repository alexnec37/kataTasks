using codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class UniqueInOrder_6_Test
    {

        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void EmptyTest()
            {
                Assert.AreEqual("", UniqueInOrder_6.UniqueInOrder(""));
            }
            [Test]
            public void Test1()
            {
                Assert.AreEqual("ABCDAB", UniqueInOrder_6.UniqueInOrder("AAAABBBCCDAABBB"));
            }
        }
    }
}
