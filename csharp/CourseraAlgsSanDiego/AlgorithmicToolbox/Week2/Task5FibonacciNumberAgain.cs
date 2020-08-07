using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week2
{
    public class Task5FibonacciNumberAgain
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

        public static long FibonacciLastDigitHuge(long n, int divider)
        {
            var pisanoPeriod = FindPisanoPeriod(n, divider);
            if (pisanoPeriod.Item1 == false)
            {
                return pisanoPeriod.Item2.Last();
            }

            var ppLength = pisanoPeriod.Item2.Count - 2;
            var index = n % ppLength;

            return pisanoPeriod.Item2[(int)index];
        }

        public static void StressTest()
        {
            while (true)
            {
                var rnd = new Random();
                var n = rnd.Next(200000, 500000);
                var divider = rnd.Next(500, 1000);

                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                var result1 = FibonacciLastDigitHuge(n, divider);
                watch1.Stop();

                Console.WriteLine($"Fi {n} % {divider}");
                Console.WriteLine($"Pisano period length {result1} for {watch1.ElapsedMilliseconds} ms");
                Thread.Sleep(5000);
            }
        }

        static void Main(string[] args)
        {
            // StressTest();
            while (true)
            {
                var arrStr = Console.ReadLine();
                var tokens = arrStr.Split(' ');
                var ar = new long[tokens.Length];

                for (int i = 0; i < tokens.Length; i++)
                {
                    ar[i] = long.Parse(tokens[i]);
                }
                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                var result = FibonacciLastDigitHuge(ar[0], (int)ar[1]);
                watch1.Stop();

                Console.Write(result + " ");
                Console.WriteLine(watch1.ElapsedMilliseconds + " ms");
            }

        }
    }
}
