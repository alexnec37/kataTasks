namespace myjinxin
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class myjinxin
    {

        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            //Assert.AreEqual("bac", kata.MiddlePermutation("abc"));
            //Assert.AreEqual("bdca", kata.MiddlePermutation("abcd"));
            //Assert.AreEqual("cbxda", kata.MiddlePermutation("abcdx"));
            //Assert.AreEqual("cxgdba", kata.MiddlePermutation("abcdxg"));
            //Assert.AreEqual("dczxgba", kata.MiddlePermutation("abcdxgz"));
            Assert.AreEqual("cbfda", kata.MiddlePermutation("abcdf"));
            Assert.AreEqual("cfedba", kata.MiddlePermutation("abcdfe"));

            //Assert.AreEqual("dczxgba", kata.MiddlePermutation("qwertyuiopasdfghjklzxcvbn"));
            //Assert.AreEqual("bdca", kata.MiddlePermutation("abcd"));
            //Assert.AreEqual("djhfecba", kata.MiddlePermutation("abcdfejh"));
        }
    }
}
