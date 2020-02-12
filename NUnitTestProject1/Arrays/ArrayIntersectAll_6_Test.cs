using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using codewars.Arrays;

namespace NUnitTestProject1.Arrays
{
    [TestFixture]
    public class ArrayIntersectAll_6_Test
    {
        [Test]
        public void BasicTests()
        {
            var a = new string[] { "dog", "bar", "foo" };
            var b = new string[] { "foo", "bar", "cat" };
            var c = new string[] { "gin", "foo", "bar" };

            Assert.AreEqual(new string[] { "bar", "foo" }, ArrayIntersectAll_6.Intersect(a, b, c));
        }

        [Test]
        public void BasicTests2()
        {
            var a = new string[] { "dog" };
            var b = new string[] { "foo" };
            var c = new string[] { "gin", "foo" };

            Assert.AreEqual(new string[] { "foo" }, ArrayIntersectAll_6.Intersect(a, b, c));
        }
    }
}
