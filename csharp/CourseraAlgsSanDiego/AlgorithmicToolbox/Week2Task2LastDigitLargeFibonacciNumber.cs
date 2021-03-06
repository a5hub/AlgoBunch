﻿using System;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    public class Week1Task2LastDigitLargeFibonacciNumber
    {
        public static int FibonacciLastDigit(int n)
        {
            if (n <= 1)
                return n;

            var prev = 0;
            var curr = 1;

            for (int i = 2; i < n; i++)
            {
                var currTmp = curr;
                curr = prev + curr;
                prev = currTmp;

            }

            return curr;
        }

        void Main(string[] args)
        {
            while (true)
            {
                var nStr = Console.ReadLine();
                var n = Int32.Parse(nStr);
                Console.WriteLine(FibonacciLastDigit(n));
            }
        }
    }

    
}
