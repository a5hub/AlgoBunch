using System;

namespace CourseraAlgsSanDiego
{
    public class LeastCommonMultiple
    {
        public static long LeastCommonMultipleCalc(long A, long B)
        {
            var maxBase = Math.Max(A, B);
            var max = maxBase;
            var min = Math.Min(A, B);

            while (max % min != 0)
            {
                max = max + maxBase;
            }

            return max;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                var arrStr = Console.ReadLine();
                var tokens = arrStr.Split(' ');
                var ar = new long[tokens.Length];

                for (int i = 0; i < tokens.Length; i++)
                {
                    ar[i] = long.Parse(tokens[i]);
                }
                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                var result = LeastCommonMultipleCalc(ar[0], ar[1]);
                watch1.Stop();

                Console.Write(result + " ");
                Console.WriteLine(watch1.ElapsedMilliseconds + " ms");
            }
        }
    }
}
