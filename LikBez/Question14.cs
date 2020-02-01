using System;
using System.Collections.Generic;
using System.Text;

namespace LikBez
{
    class Question14
    {
        void test1()
        {
            string s = null;
            Console.WriteLine(s?[0]);
        }

        private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            set
            {
                numbers[i, j] = value;
            }
        }
    }
}
