using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week4
{
    class Task1BinarySearch
    {
        private static int BinarySearch(List<int> array, int number, int start, int end)
        {
            if (end < start)
            {
                return -1;
            }
            var middle = start + (end - start) / 2;

            if (array[middle] == number)
            {
                return middle;
            }
            else if (array[middle] < number)
            {
                return BinarySearch(array, number, middle + 1, end);
            }
            else
            {
                return BinarySearch(array, number, start, middle - 1);
            }
        }

        private static List<int> Calculate(int dataCount, List<int> data, int seekCount, List<int> seek)
        {
            var result = new List<int>();
            
            for (int i = 0; i < seekCount; i++)
            {
                result.Add(BinarySearch(data, seek[i], 0, dataCount - 1));
            }
           
            return result;
        }

        //static void Main(string[] args)
        //{
        //    var dataStr = Console.ReadLine().Split(' ').ToList();
        //    var seekStr = Console.ReadLine().Split(' ').ToList();

        //    var dataCount = Int32.Parse(dataStr[0]);
        //    var data = new List<int>();
        //    for (int i = 1; i <= dataCount; i++)
        //    {
        //        data.Add(Int32.Parse(dataStr[i]));
        //    }

        //    var seekCount = Int32.Parse(seekStr[0]);
        //    var seek = new List<int>();
        //    for (int i = 1; i <= seekCount; i++)
        //    {
        //        seek.Add(Int32.Parse(seekStr[i]));
        //    }

        //    var result = Calculate(dataCount, data, seekCount, seek);

        //    foreach (var r in result)
        //    {
        //        Console.Write(r + " ");
        //    }

        //    Console.WriteLine();
        //}

        static void Main(string[] args)
        {
            //var dataStr = Console.ReadLine().Split(' ').ToList();
            //var seekStr = Console.ReadLine().Split(' ').ToList();

            var textFile =
                @"C:\Users\316887\source\repos\AlgoBunch.git\csharp\CourseraAlgsSanDiego\TestData\Week4.Task1\test2.txt";

            string[] lines = File.ReadAllLines(textFile);

            var dataStr = lines[0].Split(' ').ToList();
            var seekStr = lines[1].Split(' ').ToList();

            var dataCount = Int32.Parse(dataStr[0]);
            var data = new List<int>();
            for (int i = 1; i <= dataCount; i++)
            {
                data.Add(Int32.Parse(dataStr[i]));
            }

            var seekCount = Int32.Parse(seekStr[0]);
            var seek = new List<int>();
            for (int i = 1; i <= seekCount; i++)
            {
                seek.Add(Int32.Parse(seekStr[i]));
            }

            var result = Calculate(dataCount, data, seekCount, seek);

            foreach (var r in result)
            {
                Console.Write(r + " ");
            }

            Console.WriteLine();
        }
    }
}
