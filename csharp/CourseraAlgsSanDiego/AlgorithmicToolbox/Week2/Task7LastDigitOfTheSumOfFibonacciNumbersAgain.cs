using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week2
{
    public class Task7LastDigitOfTheSumOfFibonacciNumbersAgain
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

        public static long FSumLastDigit(long n, int divider)
        {
            var changedNumber = n + 2;
            var pisanoPeriod = FindPisanoPeriod(changedNumber, divider);
            if (pisanoPeriod.Item1 == false)
            {
                return pisanoPeriod.Item2.Last() - 1;
            }

            var ppLength = pisanoPeriod.Item2.Count - 2;
            var index = changedNumber % ppLength;

            var FLastDgigtChangedNumber = pisanoPeriod.Item2[(int)index];

            if (FLastDgigtChangedNumber == 0)
                FLastDgigtChangedNumber = 10;

            return FLastDgigtChangedNumber - 1; 
        }

        public static long Calculate(long first, long second)
        {
            var firstSumLastDigit = FSumLastDigit(first - 1, 100);
            var secondSumLastDigit = FSumLastDigit(second, 100);

            if (firstSumLastDigit >= secondSumLastDigit)
            {
                secondSumLastDigit = secondSumLastDigit + 100;
            }

            var result = (secondSumLastDigit - firstSumLastDigit) % 10;

            return result;
        }

        static void Main(string[] args)
        {
            var arrStr = Console.ReadLine();
            var tokens = arrStr.Split(' ');
            var ar = new long[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                ar[i] = long.Parse(tokens[i]);
            }
        
            var result = Calculate(ar[0], ar[1]);
            Console.WriteLine(result);
        }
    }
}