using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace PathFinder4_WhereAreYou_4_Testn
{
    public class PathFinder4_WhereAreYou_4_Test
    {
        [TestCaseSource("samples")]
        public void MyTest(string s, Point p)
        {
            Assert.AreEqual(p, PathFinder4_WhereAreYou_4.iAmHere(s));
        }

        static TestCaseData[] samples =
        {
            new TestCaseData("", new Point(0, 0)).SetName("Sample Test"),
            new TestCaseData("RLrl", new Point(0, 0)).SetName("Sample Test"),
            new TestCaseData("r5L2l4", new Point(4, 3)).SetName("Sample Test"),
            new TestCaseData("r5L2l4", new Point(0, 0)).SetName("Sample Test"),
            new TestCaseData("10r5r0", new Point(-10, 5)).SetName("Sample Test"),
            new TestCaseData("10r5r0", new Point(0, 0)).SetName("Sample Test")
        };
    }
}
