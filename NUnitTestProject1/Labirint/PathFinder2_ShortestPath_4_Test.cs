using codewars.Labirint;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Labirint
{
    [TestFixture]
    class PathFinder2_ShortestPath_4_Test
    {
        [Test]
        public void TestBasic()
        {

            string a = ".W.\n" +
                       ".W.\n" +
                       "...",

                   b = ".W.\n" +
                       ".W.\n" +
                       "W..",

                   c = "......\n" +
                       "......\n" +
                       "......\n" +
                       "......\n" +
                       "......\n" +
                       "......",

                   d = "......\n" +
                       "......\n" +
                       "......\n" +
                       "......\n" +
                       ".....W\n" +
                       "....W.",

                    e = "....W..W\n" +
                        "W.W...WW\n" +
                        "...W.W..\n" +
                        "........\n" +
                        "...WW.W.\n" +
                        ".W.W.W..\n" +
                        ".W.WW...\n" +
                        "WW......";

            Assert.AreEqual(14, PathFinder2_ShortestPath_4.PathFinder(e));
            Assert.AreEqual(4, PathFinder2_ShortestPath_4.PathFinder(a));
            Assert.AreEqual(-1, PathFinder2_ShortestPath_4.PathFinder(b));
            Assert.AreEqual(10, PathFinder2_ShortestPath_4.PathFinder(c));
            Assert.AreEqual(-1, PathFinder2_ShortestPath_4.PathFinder(d));
        }
    }
}
