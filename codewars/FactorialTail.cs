using System;
using System.Collections.Generic;
using System.Linq;

namespace codewars
{
    public class FactorialTail
    {

        //// fixme
        //public static long zeroes(int @base, int number)
        //{
        //    long factorial, trailingzeroes = 0;
        //    for (factorial = 1; number > 1; factorial *= number--) ;
        //    while (factorial % @base == 0) { factorial /= @base; ++trailingzeroes; };
        //    return trailingzeroes;
        //    //return int.Parse(@base.ToString() + "10101" + number.ToString());
        //}
        // fixme
        public static int zeroes(int @base, int number)
        {
            int i = 0, sum_deviders = 0;
            int tNumber = number;
            var deviderList = deviders(@base);
            
            int[] trailingzeroes = new int[deviderList.Count];

            foreach (var devider in deviderList)
            {
                int maxdevider = devider.Item1;

                while (tNumber / maxdevider > 0)
                {
                    tNumber /= maxdevider;

                    sum_deviders += tNumber;
                };

                trailingzeroes[i++] = sum_deviders / devider.Item2;
                sum_deviders = 0;
                tNumber = number;
            }

            int trailingzeroesMin = trailingzeroes.Min();
            return trailingzeroesMin;//int.Parse(@base.ToString() + "10101" + number.ToString());
        }

        static List<(int, int)> deviders(int @base)
        {
            var primes = get_primes(@base);
            int dev_count = 0;
            List<(int, int)> deviders = new List<(int, int)>();

            foreach(var devider in primes)
            {

                if (@base % devider != 0)
                {
                    continue;
                }

                while (@base % devider == 0)
                {
                    @base /= devider;
                    dev_count++;
                }

                deviders.Add((devider, dev_count));
                dev_count = 0;
            }

            if (deviders.Count == 0)
            {
                deviders.Add((@base, 1));
            }

            return deviders;
        }

        static int prime(int num)
        {
            int i, flag = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                return 1;
            else
                return 0;
        }

        static IList<int> get_primes(int n)
        {
            List<int> prime_nums = new List<int>();
            
            for (int num = 2; num < n; num++)
            {
                if (prime(num) == 1)
                {
                    prime_nums.Add(num);
                }
            }

            return prime_nums;
        }
    }
}
