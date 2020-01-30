namespace Solution
{
    using codewars;
    using NUnit.Framework;
    using System;

    // TODO: Replace examples and use TDD development by writing your own tests

    [TestFixture]
    public class AddingBigNumbersTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("4444", AddingBigNumbers.Add("123", "4321"));
            Assert.AreEqual("37657756", AddingBigNumbers.Add("3423432", "34234324"));
            //Assert.AreEqual("expected", "actual");
        }
    }
}