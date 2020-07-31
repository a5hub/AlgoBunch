using HackerRank.InterviewPreparationKit.Arrays;
using System;
using LeetCode;
using CourseraAlgsSanDiego;

namespace AlgoBunch
{
    class Program
    {
        public static void StressTest(int N, int M)
        {
            var testedObject = new MaximumPairwiseProduct();

            while (true)
            {
                var rnd = new Random();
                var n = rnd.Next(2, N);
                var ar = new int[n];
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = rnd.Next(1, M);
                }

                foreach (var a in ar)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();

                var result1 = testedObject.MaxPairwiseProductNaive(ar);
                var result2 = testedObject.MaxPairwiseProductFast(ar);

                if (result1 == result2)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine($"Wrong answer {result1}, {result2}");
                    break;
                }
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            StressTest(10000, 20000000);
            //var testedObject = new MaximumPairwiseProduct();
            //var arr = new [] { 100000, 90000 };
            //var result = testedObject.MaxPairwiseProductFast(arr);

            //Console.WriteLine(result);
            //Console.ReadKey();

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //Console.ReadKey();
        }
    }
}
