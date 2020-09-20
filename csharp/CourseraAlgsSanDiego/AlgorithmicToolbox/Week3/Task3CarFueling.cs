using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week3
{
    class Task3CarFueling
    {
        private static int Calculate(List<int> stops, int capacity)
        {
            var currentRefill = 0;
            var numRefills = 0;
            var totalStops = stops.Count - 2;

            while (currentRefill <= totalStops)
            {
                var lastRefill = currentRefill;
                while (currentRefill <= totalStops && 
                       stops[currentRefill + 1] - stops[lastRefill] <= capacity)
                {
                    currentRefill = currentRefill + 1;
                }

                if (currentRefill == lastRefill)
                {
                    return -1;
                }

                if (currentRefill <= totalStops)
                {
                    numRefills += 1;
                }
            }

            return numRefills;
        }

        static void Main(string[] args)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            var textFile =
                @"C:\Users\316887\source\repos\AlgoBunch.git\csharp\CourseraAlgsSanDiego\TestData\Week3.Task3CarFueling\test3.txt";

            string[] lines = File.ReadAllLines(textFile);
            
            var distance = Int32.Parse(lines[0]);
            var tankCapacity = Int32.Parse(lines[1]);
            var stopsStr = lines[3].Split(' ').ToList();

            var stops = new List<int> { 0 };
            for (int i = 0; i < stopsStr.Count; i++)
            {
                stops.Add(Int32.Parse(stopsStr[i]));
            }
            stops.Add(distance);

            var result = Calculate(stops, tankCapacity);
            watch1.Stop();

            Console.WriteLine(result + " " + watch1.ElapsedMilliseconds + "ms");
        }
    }
}
