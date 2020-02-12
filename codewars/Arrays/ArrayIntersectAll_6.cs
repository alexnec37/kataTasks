using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.Arrays
{
    public class ArrayIntersectAll_6
    {
        public static string[] Intersect(params string[][] arrays)
        {
            if (arrays.Length == 0) return new string[0];

            string[] preArray;
            preArray = arrays[0];

            for (int i = 1; i < arrays.Length; i++)
            {
                preArray = IntersectArray(preArray, arrays[i]);
                if(preArray.Length == 0)
                {
                    preArray = arrays[i];
                }
            }

            return preArray;
        }

        static string[] IntersectArray(string[] a, string[] b)
        {
            int k = 0;
            int size = a.Length > b.Length ? b.Length : a.Length;
            string[] c = new string[size];

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if(a[i] == b[j])
                    {
                        c[k] = a[i];
                        k++;
                    }
                }
            }

            Array.Resize(ref c, k);
            return c;
        }

        static string[] IntersectSorted(string[] a, string[] b)
        {
            int size = a.Length > b.Length ? b.Length : a.Length;
            string[] c = new string[size];
            int i = 0, j = 0, k = 0;

            while (i < a.Length || j < b.Length)
            {
                if (a[i].CompareTo(b[j]) > 0) 
                    j++;
                else if (a[i].CompareTo(b[j]) < 0)
                    i++;
                else
                {
                    c[k++] = a[i];
                    if (i == a.Length - 1 || j == b.Length - 1)
                        break;
                    else
                    {
                        i++;
                        j++;
                    }
                }
            }
            Console.WriteLine();
            Array.Resize(ref c, k);
            return c;
        }
    }
}
