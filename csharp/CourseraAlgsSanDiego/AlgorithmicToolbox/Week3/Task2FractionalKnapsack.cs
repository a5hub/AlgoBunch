using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week3
{
    class Task2FractionalKnapsack
    {
        private static void QuickSortTwoDimArrayAsc(decimal[,] arr, int column, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = PartitionAsc(arr, column, start, end);
 
                QuickSortTwoDimArrayAsc(arr, column, start, i - 1);
                QuickSortTwoDimArrayAsc(arr, column, i + 1, end);
            }
        }
 
        private static int PartitionAsc(decimal[,] arr, int column, int start, int end)
        {
            var length = arr.GetLength(1);
            decimal temp;
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

        private static void QuickSortTwoDimArrayDesc(decimal[,] arr, int column, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = PartitionDesc(arr, column, start, end);
 
                QuickSortTwoDimArrayDesc(arr, column, start, i - 1);
                QuickSortTwoDimArrayDesc(arr, column, i + 1, end);
            }
        }
 
        private static int PartitionDesc(decimal[,] arr, int column, int start, int end)
        {
            var length = arr.GetLength(1);
            decimal temp;
            var p = arr[start, column];
            var i = start;
 
            for (int j = start + 1; j <= end; j++)
            {
                if (arr[j, column] >= p)
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
                temp = arr[i, k];
                arr[i, k] = arr[start, k];
                arr[start, k] = temp;
            }
            
            return i;
        }

        private static decimal Calculate(int knapsackCapacity, int itemsAmount, decimal[,] items)
        {
            if (knapsackCapacity == 0) return 0;

            var capacity = (decimal) knapsackCapacity;

            decimal value = 0;
            for (int i = 0; i < itemsAmount; i++)
            {
                var a = Math.Min(items[i, 1], capacity);

                value = value + a * items[i, 2];

                capacity = capacity - a;
            }

            return value;
        }

        static void Main(string[] args)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            var textFile =
                @"C:\Users\316887\source\repos\AlgoBunch.git\csharp\CourseraAlgsSanDiego\TestData\Week3.Task2FractionalKnapsack\test4.txt";

            string[] lines = File.ReadAllLines(textFile);
            
            // Get task condition parameters
            var condition = lines[0].Split(' ');
           
            var itemsAmount = Int32.Parse(condition[0]);
            var knapsackCapacity = Int32.Parse(condition[1]);

            // Get items parameters
            var data = new decimal[itemsAmount, 3];
            for (int i = 0; i < itemsAmount; i++)
            {
                var item = lines[i + 1].Split(' ');
                
                var value = Int32.Parse(item[0]);
                var weight = Int32.Parse(item[1]);

                data[i, 0] = value;
                data[i, 1] = weight;
                data[i, 2] = (decimal) value / weight; //ratio
            }


            QuickSortTwoDimArrayDesc(data, 2, 0, itemsAmount - 1);
            
            
            var result = Calculate(knapsackCapacity, itemsAmount, data);
            watch1.Stop();

            Console.WriteLine(result + " " + watch1.ElapsedMilliseconds + "ms");
        }

        static void MainTwo(string[] args)
        {
            // Get task condition parameters
            var condition = Console.ReadLine().Split(' ');
           
            var itemsAmount = Int32.Parse(condition[0]);
            var knapsackCapacity = Int32.Parse(condition[1]);

            // Get items parameters
            var data = new decimal[itemsAmount, 3];
            for (int i = 0; i < itemsAmount; i++)
            {
                var item = Console.ReadLine().Split(' ');
                
                var value = Int32.Parse(item[0]);
                var weight = Int32.Parse(item[1]);

                data[i, 0] = value;
                data[i, 1] = weight;
                data[i, 2] = (decimal) value / weight; //ratio
            }

            QuickSortTwoDimArrayDesc(data, 2, 0, itemsAmount - 1);
            
            var result = Math.Round(Calculate(knapsackCapacity, itemsAmount, data), 4);

            Console.WriteLine(result);
        }
    }
}
