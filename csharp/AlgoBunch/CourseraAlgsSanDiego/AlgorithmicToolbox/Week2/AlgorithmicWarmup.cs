using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego
{
    public class AlgorithmicWarmup
    {
        public int FibonacciNaive(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciNaive(n - 1) + FibonacciNaive(n - 2);
        }

        public int FibonacciFast(int n, int[] nums)
        {
            if (n <= 1)
                return n;
            if (nums[n - 1] != 0 && nums[n - 2] != 0)
            {
                return nums[n - 1] + nums[n - 2];
            }
            else
            {
                nums[n - 1] = FibonacciFast(n - 1, nums);
                nums[n - 2] = FibonacciFast(n - 2, nums);

                return nums[n - 1] + nums[n - 2];
            }
                
        }

        public int FibonacciFastWrapped(int n)
        {
            var nums = new int[n];

            return FibonacciFast(n, nums);
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
                var result2 = FibonacciFastWrapped(n);
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

        public void Main(string[] args)
        {
            Console.ReadLine();
            var nStr = Console.ReadLine();
            var n = Int32.Parse(nStr);

            var result = FibonacciNaive(n);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
