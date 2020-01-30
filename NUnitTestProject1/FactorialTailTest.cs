namespace Solution
{
    using codewars;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Can_Be_Solved_With_Basic_Computations()
        {
            Assert.AreEqual(11, FactorialTail.zeroes(12, 27));
            Assert.AreEqual(2, FactorialTail.zeroes(9, 11));
            Assert.AreEqual(1, FactorialTail.zeroes(5, 9));
            Assert.AreEqual(2, FactorialTail.zeroes(5, 12));
            Assert.AreEqual(2, FactorialTail.zeroes(10, 10));
            Assert.AreEqual(3, FactorialTail.zeroes(16, 16));
            Assert.AreEqual(1, FactorialTail.zeroes(12, 5));
            Assert.AreEqual(5, FactorialTail.zeroes(12, 12));
        }
    }
}