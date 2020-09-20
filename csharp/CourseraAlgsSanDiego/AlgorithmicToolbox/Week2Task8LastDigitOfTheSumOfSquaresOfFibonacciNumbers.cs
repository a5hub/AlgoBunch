using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    public class Week2Task8LastDigitOfTheSumOfSquaresOfFibonacciNumbers
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

            for (long i = 2; i <= n; i++)
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

        /// <summary> Calculate last digit from Fibonacci number </summary>
        /// <param name="n"> Number to calculate it's last number of Fib.</param>
        public static long CalcFnLastDigit(long n)
        {
            var divider = 10;
            var pisanoPeriod = FindPisanoPeriod(n, divider);
            if (pisanoPeriod.Item1 == false)
            {
                return pisanoPeriod.Item2.Last();
            }

            var ppLength = pisanoPeriod.Item2.Count - 2;
            var index = n % ppLength;

            var FLastDgigtChangedNumber = pisanoPeriod.Item2[(int)index];

            if (FLastDgigtChangedNumber == 0)
                FLastDgigtChangedNumber = 10;

            return FLastDgigtChangedNumber; 
        }

        public static long Calculate(long n)
        {
            var fnLastDigit = CalcFnLastDigit(n);
            var previousFnLastDigit = CalcFnLastDigit(n - 1);

            return fnLastDigit * (fnLastDigit + previousFnLastDigit) % 10;
        }

        static void Main(string[] args)
        {
            var nStr = Console.ReadLine();
            var n = Int64.Parse(nStr);
            
            var result = Calculate(n);
            
            Console.WriteLine(result); 
        }
    }
}