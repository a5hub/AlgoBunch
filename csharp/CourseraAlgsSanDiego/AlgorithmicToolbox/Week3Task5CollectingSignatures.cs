using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    class Week3Task5CollectingSignatures
    {
         private static void QuickSortTwoDimArrayAsc(int[,] arr, int column, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = PartitionAsc(arr, column, start, end);
 
                QuickSortTwoDimArrayAsc(arr, column, start, i - 1);
                QuickSortTwoDimArrayAsc(arr, column, i + 1, end);
            }
        }
 
        private static int PartitionAsc(int[,] arr, int column, int start, int end)
        {
            var length = arr.GetLength(1);
            int temp;
            var p = arr[end, column];
            var i = start - 1;
 
            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j, column] <= p)
                {
                    i++;
                    for (int k = 0; k < length; k++)
                    {
                        temp = arr[i, k];
                        arr[i, k] = arr[j, k];
                        arr[j, k] = temp;
                    }
                }
            }

            for (int k = 0; k < length; k++)
            {
                temp = arr[i + 1, k];
                arr[i + 1, k] = arr[end, k];
                arr[end, k] = temp;
            }
            
            return i + 1;
        }

        private static Tuple<int, List<int>> Calculate(int[,] segments, int segmentsCnt)
        {
            QuickSortTwoDimArrayAsc(segments, 1, 0, segmentsCnt - 1);

            var pointCnt = 1;
            var points = new List<int>{segments[0, 1]};
            for (int i = 0; i < segmentsCnt - 1; i++)
            {
                if (points.Max() < segments[i + 1, 0])
                {
                    points.Add(segments[i + 1, 1]);
                    pointCnt++;
                }
            }

            return new Tuple<int, List<int>>(pointCnt, points);
        }

        static void Main(string[] args)
        {
            var segmentsCnt = Int32.Parse(Console.ReadLine());

            var segments = new int[segmentsCnt, 2];
            for (int i = 0; i < segmentsCnt; i++)
            {
                var segmentsStr = Console.ReadLine().Split(' ').ToList();
                segments[i, 0] = Int32.Parse(segmentsStr[0]);
                segments[i, 1] = Int32.Parse(segmentsStr[1]);
            }

            var result = Calculate(segments, segmentsCnt);

            Console.WriteLine(result.Item1);
            foreach (var i in result.Item2)
            {
                Console.Write(i + " ");
            }
        }

        //static void Main(string[] args)
        //{
        //    var textFile =
        //        @"C:\Users\316887\source\repos\AlgoBunch.git\csharp\CourseraAlgsSanDiego\TestData\Week3.Task5\test1.txt";

        //    string[] lines = File.ReadAllLines(textFile);

        //    var segmentsCnt = Int32.Parse(lines[0]);

        //    var segments = new int[segmentsCnt, 2];
        //    for (int i = 0; i < segmentsCnt; i++)
        //    {
        //        var segmentsStr = lines[i + 1].Split(' ').ToList();
        //        segments[i, 0] = Int32.Parse(segmentsStr[0]);
        //        segments[i, 1] = Int32.Parse(segmentsStr[1]);
        //    }

        //    var result = Calculate(segments, segmentsCnt);

        //    Console.WriteLine(result.Item1);
        //    foreach (var i in result.Item2)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
    }
}
