using System;

namespace CourseraAlgsSanDiego
{
    public class LastDigitLargeFibonacciNumber
    {
        public int FibonacciLastDigitCalc(int n, int[] nums)
        {
            if (n <= 1)
                return n;
            if (nums[n - 1] != 0 && nums[n - 2] != 0)
            {
                return (nums[n - 1] + nums[n - 2]) % 10;
            }

            nums[n - 1] = FibonacciLastDigitCalc(n - 1, nums);
            nums[n - 2] = FibonacciLastDigitCalc(n - 2, nums);

            return (nums[n - 1] + nums[n - 2]) % 10;
        }


        public int FibonacciLastDigit(int n)
        {
            var nums = new int[n];

            return FibonacciLastDigitCalc(n, nums);
        }

        public void StressTest(int M, int N)
        {
            while (true)
            {
                var rnd = new Random();
                var n = rnd.Next(M, N);

                var fibNum = new FibonacciNumber();

                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                var result1 = fibNum.FibonacciFast(n) % 10;
                watch1.Stop();

                var watch2 = System.Diagnostics.Stopwatch.StartNew();
                var result2 = FibonacciLastDigit(n);
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

    }
}
