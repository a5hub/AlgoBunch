using System;
using System.Collections.Generic;
using System.Threading;

namespace CourseraAlgsSanDiego
{
    public class LastDigitLargeFibonacciNumberReallyHuge
    {
        public static List<long> FindPisanoPeriod(long n, long divider)
        {
            var pisanoPeriod = new List<long> { 0, 1 };

            long previous = 0;
            long current = 1;

            for (int i = 2; i < n - 1; ++i)
            {
                long tmp_previous = previous;
                previous = current;
                current = (tmp_previous + current) % divider;
                pisanoPeriod.Add(current);
                if (previous == 0 && current == 1)
                    break;
            }

            return pisanoPeriod;
        }

        public static long FibonacciLastDigitHuge(long n, long divider)
        {
            var pisanoPeriod = FindPisanoPeriod(n, divider);
            var pisanoPeriodLength = pisanoPeriod.Count - 2;

            var tt = (int)n % pisanoPeriodLength;
            return pisanoPeriod[tt];
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
                var result = FibonacciLastDigitHuge(ar[0], ar[1]);
                watch1.Stop();

                Console.Write(result + " ");
                Console.WriteLine(watch1.ElapsedMilliseconds + " ms");
            }

        }
    }

    
}
