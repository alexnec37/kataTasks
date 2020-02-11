using System;
using System.Collections.Generic;
using System.Text;
using codewars.Mathematics.MatrixDeterminant_4;

namespace NUnitTestProject1.Mathematics.MatrixDeterminant_4
{
    using NUnit.Framework;
    using System;
    public class SolutionTest
    {

        private static int[][][] matrix =
        {
        new int[][] { new [] { 1 } },
        new int[][] { new [] { 1, 3 }, new [] { 2, 5 } },
        new int[][] { new [] { 2, 5, 3 }, new [] { 1, -2, -1 }, new [] { 1, 3, 4 } }
    };

        private static int[] expected = { 1, -1, -20 };

        private static string[] msg = { "Determinant of a 1 x 1 matrix yields the value of the one element", "Should return 1 * 5 - 3 * 2 == -1 ", "" };

        [Test]
        public void SampleTests()
        {
            for (int n = 0; n < expected.Length; n++)
                Assert.AreEqual(expected[n], Matrix.Determinant(matrix[n]), msg[n]);
        }
    }
}
