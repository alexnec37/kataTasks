using codewars.Labirint;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Labirint
{
    [TestFixture]
    public class PathFinder3__ЕheAlpinist_3_Test
    {
        [Test]
        public void SampleTests()
        {

            string a = "000\n" +
                       "000\n" +
                       "000",

                   b = "010\n" +
                       "010\n" +
                       "010",

                   c = "010\n" +
                       "101\n" +
                       "010",

                   d = "0707\n" +
                       "7070\n" +
                       "0707\n" +
                       "7070",

                   e = "700000\n" +
                       "077770\n" +
                       "077770\n" +
                       "077770\n" +
                       "077770\n" +
                       "000007",

                   f = "777000\n" +
                       "007000\n" +
                       "007000\n" +
                       "007000\n" +
                       "007000\n" +
                       "007777",

                   g = "000000\n" +
                       "000000\n" +
                       "000000\n" +
                       "000010\n" +
                       "000109\n" +
                       "001010",

                   h = "026\n" +
                       "493\n" +
                       "175",

                   i = "1165\n" +
                       "0854\n" +
                       "2365\n" +
                       "2106";

            Assert.AreEqual(9, PathFinder3__ЕheAlpinist_3.PathFinder(i));
            Assert.AreEqual(11, PathFinder3__ЕheAlpinist_3.PathFinder(h));
            Assert.AreEqual(0, PathFinder3__ЕheAlpinist_3.PathFinder(a));
            Assert.AreEqual(2, PathFinder3__ЕheAlpinist_3.PathFinder(b));
            Assert.AreEqual(4, PathFinder3__ЕheAlpinist_3.PathFinder(c));
            Assert.AreEqual(42, PathFinder3__ЕheAlpinist_3.PathFinder(d));
            Assert.AreEqual(14, PathFinder3__ЕheAlpinist_3.PathFinder(e));
            Assert.AreEqual(0, PathFinder3__ЕheAlpinist_3.PathFinder(f));
            Assert.AreEqual(4, PathFinder3__ЕheAlpinist_3.PathFinder(g));
        }
    }
}
