using System;

namespace CourseraAlgsSanDiego
{
    public class FibonacciNumber
    {
        public int FibonacciNaive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciNaive(n - 1) + FibonacciNaive(n - 2);
        }

        public long FibonacciFastCalc(int n, long[] nums)
        {
            if (n <= 1)
                return n;
            if (nums[n - 1] != 0 && nums[n - 2] != 0)
            {
                return nums[n - 1] + nums[n - 2];
            }

            nums[n - 1] = FibonacciFastCalc(n - 1, nums);
            nums[n - 2] = FibonacciFastCalc(n - 2, nums);

            return nums[n - 1] + nums[n - 2];
        }

        public long FibonacciFast(int n)
        {
            var nums = new long[n];

            return FibonacciFastCalc(n, nums);
        }

        public void StressTest(int M, int N)
        {
            while (true)
            {
                var rnd = new Random();
                var n = rnd.Next(M, N);

                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                var result1 = FibonacciNaive(n);
                watch1.Stop();

                var watch2 = System.Diagnostics.Stopwatch.StartNew();
                var result2 = FibonacciFast(n);
                watch2.Stop();

                Console.WriteLine(n);
                Console.WriteLine($"Answer {result1} for {watch1.ElapsedMilliseconds} ms, {result2} for {watch2.ElapsedMilliseconds} ms");

                if (result1 == result2)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    break;
                }
            }
        }

        void Main(string[] args)
        {
            var nStr = Console.ReadLine();
            var n = Int32.Parse(nStr);

            Console.WriteLine(FibonacciFast(n));
        }
    }
}
