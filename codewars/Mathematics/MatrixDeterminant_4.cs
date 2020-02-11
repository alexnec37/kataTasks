using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.Mathematics.MatrixDeterminant_4
{
    public class Matrix
    {
        public static int Determinant(int[][] matrix)
        {
            int x = Det(matrix);
            return x;
        }

        static int Det(int[][] matrix)
        {
            if (matrix.Length == 1)
            {
                return matrix[0][0];
            }

            int det = 0;
            for(int row = 0; row < matrix.Length; row++)
            {
                var minor = Minor(matrix, row, 0);
                det += (int)Math.Pow(-1, row) * matrix[row][0] * Det(minor);
            }

            return det;
        }

        static int[][] Minor(int[][] matrix, int i, int j)
        {
            int[][] minor = new int[matrix.Length - 1][];
            int m_row = 0, m_col = 0;

            for(int row = 0; row < matrix.Length; row++)
            {
                if (row == i) continue;

                minor[m_row] = new int[matrix[i].Length - 1];
                for (int col = 0; col < matrix[i].Length; col++)
                {
                    if (col == j) continue;
                    minor[m_row][m_col] = matrix[row][col];
                    m_col++;
                }

                m_col = 0;
                m_row++;
            }

            return minor;
        }
    }
}
