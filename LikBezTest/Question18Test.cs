using LikBez;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAs()
        {
            Question18.TestAs();
            Assert.Pass();
        }

        [Test]
        public void TestIs()
        {
            Question18.TestIs();
            Assert.Pass();
        }
    }
}