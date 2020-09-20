using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    public class Week2Task6LastDigitOfTheSumOfFibonacciNumbers
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

        public static long FubonacciSumLastNumber(long n)
        {
            var changedNumber = n + 2;
            var pisanoPeriod = FindPisanoPeriod(changedNumber, 10);
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

        static void Main(string[] args)
        {
            var fStr = Console.ReadLine();
        
            var number = Int64.Parse(fStr);
        
            var result = FubonacciSumLastNumber(number);
        
            Console.WriteLine(result);
        }
    }
}
