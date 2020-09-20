using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week3
{
    class Task6MaximumNumberOfPrizes
    {
         private static Tuple<int, List<int>> Calculate(int n)
        {
            var m = 0;
            var nums = new List<int>();
            var counter = 0;

            while(n > 0)
            {
                m++;
                if (n - m >= 0  && m != n - m && n - m >= m + 1)
                {
                    nums.Add(m);
                    n -= m;
                    counter++;
                    continue;
                }

                nums.Add(n);
                counter++;
                break;
            }
            
            return Tuple.Create(counter, nums);
        }

        //static void StessTest()
        //{
        //    while(true)
        //    {
        //        var rnd = new Random();
        //        var n = rnd.Next(100, 1000);

        //        var result = Calculate(n);

        //        Console.WriteLine(result.Item1);
        //        foreach (var i in result.Item2)
        //        {
        //            Console.Write(i + " ");
        //        }

        //        Console.WriteLine();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    StessTest();
        //}


        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        var number = Int32.Parse(Console.ReadLine());

        //        var watch1 = System.Diagnostics.Stopwatch.StartNew();
        //        var result = Calculate(number);
        //        watch1.Stop();

        //        Console.WriteLine(result.Item1);
        //        foreach (var i in result.Item2)
        //        {
        //            Console.Write(i + " ");
        //        }

        //        Console.WriteLine();
        //        Console.WriteLine(watch1.ElapsedMilliseconds);
        //    }
        //}


        static void Main(string[] args)
        {
            var number = Int32.Parse(Console.ReadLine());

            var result = Calculate(number);

            Console.WriteLine(result.Item1);
            foreach (var i in result.Item2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
