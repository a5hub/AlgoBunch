﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoBunch
{
    class Program
    {
        public static Tuple<bool, List<int>> FindPisanoPeriod(long n, int divider)
        {
            var pisanoPeriod = new List<int> { 0, 1 };

            int previous = 0;
            int current = 1;

            if (n == 0 || divider == 0)
            {
                return new Tuple<bool, List<int>>(false, new List<int> { 0 });
            }
            if (n <= 2)
            {
                return new Tuple<bool, List<int>>(false, pisanoPeriod);
            }

            for (int i = 2; i <= n; i++)
            {
                int tmpPrevious = previous;
                previous = current;
                current = (tmpPrevious + current) % divider;
                pisanoPeriod.Add(current);

                if (previous == 0 && current == 1)
                {
                    break;
                }

                if (i == n)
                {
                    return new Tuple<bool, List<int>>(false, pisanoPeriod);
                }
            }

            return new Tuple<bool, List<int>>(true, pisanoPeriod);
        }

        public static long FibonacciLastDigitHuge(long n)
        {
            var pisanoPeriod = FindPisanoPeriod(n, 10);
            if (pisanoPeriod.Item1 == false)
            {
                return pisanoPeriod.Item2.Last();
            }

            var ppLength = pisanoPeriod.Item2.Count - 2;
            var index = n % ppLength;

            return pisanoPeriod.Item2[(int)index];
        }


        static void Main(string[] args)
        {
            while (true)
            {
                var fStr = Console.ReadLine();

                var number = Int64.Parse(fStr);

                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                for (int i = 0; i <= number; i++)
                {
                    var result = FibonacciLastDigitHuge(i);
                }
                watch1.Stop();
                Console.WriteLine(watch1.ElapsedMilliseconds);
            }





        }
    }
}
