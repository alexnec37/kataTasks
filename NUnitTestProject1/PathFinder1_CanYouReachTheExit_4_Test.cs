using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using nPathFinder1_CanYouReachTheExit_4;

namespace NUnitTestProject1
{
    [TestFixture]
    public class PathFinder1_CanYouReachTheExit_4_Test
    {
        [Test]
        public void sampleTests()
        {

            string y =  "............W......W.W\n" +
                        "..........WW........W.\n" +
                        "WW.W...W..WW......WW.W\n" +
                        ".W.....W...W.......W..\n" +
                        "..W..W......W...W.W...\n" +
                        "..W......W.W.....W...W\n" +
                        ".WWW.W....WWW........W\n" +
                        "W.W..W.W..W...W...WWW.\n" +
                        "W.W.....W.WW..W..W....\n" +
                        "W.W......W.W...W.....W\n" +
                        ".W..W.W......W.......W\n" +
                        "....WW..W...W...W.....\n" +
                        ".........WW.W.........\n" +
                        "W...WW..WW.WWW...W.W..\n" +
                        "W.WW..W.....WW.WW...W.\n" +
                        ".W...W...W....W...W...\n" +
                        "WW....WW...W..W..W.W..\n" +
                        ".W........W.W.........\n" +
                        "..............W.W....W\n" +
                        "WWW.W..W.W.W.....W...W\n" +
                        "W...WW.W..WW..W...W...\n" +
                        "W................W..W.",


                   z = ".",

                   a = ".W.\n" +
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
                       "....W.";

            Assert.AreEqual(true, PathFinder1_CanYouReachTheExit_4.PathFinder(y));
            //Assert.AreEqual(true, PathFinder1_CanYouReachTheExit_4.PathFinder(z));
            //Assert.AreEqual(true, PathFinder1_CanYouReachTheExit_4.PathFinder(a));
            //Assert.AreEqual(false, PathFinder1_CanYouReachTheExit_4.PathFinder(b));
            //Assert.AreEqual(true, PathFinder1_CanYouReachTheExit_4.PathFinder(c));
            //Assert.AreEqual(false, PathFinder1_CanYouReachTheExit_4.PathFinder(d));
        }
    }
}
