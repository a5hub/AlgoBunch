using System;
using System.Collections.Generic;
using System.Threading;
using LeetCode;

namespace AlgoBunch
{
    class Program
    { 
        static void Main(string[] args)
        {
            var array = new char[] {'a', 'b', 'c', 'd', 'e', 'f'};
            ReverseStringTask.ReverseString(array);
            //Console.WriteLine($"{res[0]}, {res[1]}");
            Console.ReadLine();

            // StressTest();
            //while (true)
            //{
            //    var arrStr = Console.ReadLine();
            //    var tokens = arrStr.Split(' ');
            //    var ar = new long[tokens.Length];

            //    for (int i = 0; i < tokens.Length; i++)
            //    {
            //        ar[i] = long.Parse(tokens[i]);
            //    }
            //    var watch1 = System.Diagnostics.Stopwatch.StartNew();
            //    var result = FibonacciLastDigitHuge(ar[0], ar[1]);
            //    watch1.Stop();

            //    Console.Write(result + " ");
            //    Console.WriteLine(watch1.ElapsedMilliseconds + " ms");
            //}

        }
    }
}
