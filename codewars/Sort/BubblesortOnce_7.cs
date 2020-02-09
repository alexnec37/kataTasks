using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.Sort
{
    public class BubblesortOnce_7
    {
        public static int[] BubbleSortOnce(int[] input)
        {
            //var actual = new int[] { 9, 7, 5, 3, 1, 2, 4, 6, 8 };
            int x;
            for(int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if(input[j] > input[j+1])
                    {
                        x = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = x;
                    }
                }

                break;
            }

            return input;
        }
    }
}
