using codewars.Sort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Sort
{
    [TestFixture]
    public class BubblesortOnce_7_Test
    {
        [Test]
        public void ExampleTest()
        {
            // Example test case from description

            var expected = new int[] { 7, 5, 3, 1, 2, 4, 6, 8, 9 };
            var actual = new int[] { 9, 7, 5, 3, 1, 2, 4, 6, 8 };
            Assert.AreEqual(expected, BubblesortOnce_7.BubbleSortOnce(actual));
        }
    }
}
