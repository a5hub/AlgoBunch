﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    public class Week2Task3GreatestCommonDivisor
    {
        public static long GDC(long A, long B)
        {
            if (B == 0)
                return A;

            decimal divided = A / B;
            var first = B;
            var truncatedDivider = Math.Truncate(divided);
            var second = (long)(A - B * truncatedDivider);
            return GDC(first, second);
        }

        static void Main(string[] args)
        {

            while (true)
            {
                var arrStr = Console.ReadLine();
                var tokens = arrStr.Split(' ');
                var ar = new Int64[tokens.Length];

                for (int i = 0; i < tokens.Length; i++)
                {
                    ar[i] = Int64.Parse(tokens[i]);
                }
                Console.WriteLine(GDC(ar[0], ar[1]));
            }
        }
    }
}
