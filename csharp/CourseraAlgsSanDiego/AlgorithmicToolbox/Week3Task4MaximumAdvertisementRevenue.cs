using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    class Week3Task4MaximumAdvertisementRevenue
    {
        private static decimal Calculate(List<decimal> first, List<decimal> second)
        {
            first.Sort();
            second.Sort();

            var product = first.Zip(second, (d1, d2) => d1 * d2).Sum();

            return product;
        }

        //static void Main(string[] args)
        //{
        //    var textFile =
        //        @"C:\Users\316887\source\repos\AlgoBunch.git\csharp\CourseraAlgsSanDiego\TestData\Week3.Task4\test1.txt";

        //    string[] lines = File.ReadAllLines(textFile);

        //    var firstStr = lines[1].Split(' ').ToList();
        //    var secondStr = lines[2].Split(' ').ToList();

        //    var first = new List<decimal>();
        //    var second = new List<decimal>();
        //    for (int i = 0; i < firstStr.Count; i++)
        //    {
        //        first.Add(Decimal.Parse(firstStr[i]));
        //        second.Add(Decimal.Parse(secondStr[i]));
        //    }

        //    var result = Calculate(first, second);

        //    Console.WriteLine(result);
        //}

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            var firstStr = Console.ReadLine().Split(' ').ToList();
            var secondStr = Console.ReadLine().Split(' ').ToList();

            var first = new List<decimal>();
            var second = new List<decimal>();
            for (int i = 0; i < firstStr.Count; i++)
            {
                first.Add(Decimal.Parse(firstStr[i]));
                second.Add(Decimal.Parse(secondStr[i]));
            }

            var result = Calculate(first, second);

            Console.WriteLine(result);
        }
    }
}
