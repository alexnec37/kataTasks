using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars
{
    public class AddingBigNumbers
    {
        static int BASE = 10;

        public static string Add(string a, string b)
        {
            var aa = a.Reverse().Select(x => int.Parse(x.ToString())).ToArray();
            var bb = b.Reverse().Select(x => int.Parse(x.ToString())).ToArray();

            AddBig(aa, bb, out int[] c);

            Array.Reverse(c);

            return String.Join("", c);
        }

        unsafe static void AddBig(int[] a, int[] b, out int[] c)
        {
            if (a.Length < b.Length)
            {
                AddBig(b, a, out c);
                return;
            }

            int temp;
            short carry = 0;
            c = new int[a.Length];
            fixed(int* aa = a, bb = b, cc = c)
            {
                int i;
                for (i = 0; i < b.Length; i++)
                {
                    temp = a[i] + b[i] + carry;
                    if (temp >= BASE)
                    {
                        c[i] = temp - BASE;
                        carry = 1;
                    }
                    else
                    {
                        c[i] = temp;
                        carry = 0;
                    }
                }

                for (; i < a.Length; i++)
                {
                    temp = a[i] + carry;
                    if (temp >= BASE)
                    {
                        c[i] = temp - BASE;
                        carry = 1;
                    }
                    else
                    {
                        c[i] = temp;
                        carry = 0;
                    }
                }

                if (carry > 0)
                {
                    Array.Resize(ref c, c.Length + 1);
                    c[i] = carry;
                }
            }
        }
    }   
}
    