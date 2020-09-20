using System;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    public class Week1Task1MaximumPairwiseProduct
    {
        /// <summary> stress test O(n^2) and O(n) solution </summary>
        public static void StressTest(int N, int M)
        {
            var testedObject = new Week1Task1MaximumPairwiseProduct();

            while (true)
            {
                var rnd = new Random();
                var n = rnd.Next(2, N);
                var ar = new int[n];
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = rnd.Next(1, M);
                }

                foreach (var a in ar)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();

                var result1 = testedObject.MaxPairwiseProductNaive(ar);
                var result2 = testedObject.MaxPairwiseProductFast(ar);

                if (result1 == result2)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine($"Wrong answer {result1}, {result2}");
                    break;
                }
            }

            Console.ReadKey();
        }

        /// <summary> O(n^2) solution </summary>
        public long MaxPairwiseProductNaive(int[] arr)
        {
            long result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    result = Math.Max(result, (long) arr[i] * arr[j]);
                }
            }

            return result;
        }

        /// <summary> O(n) solution </summary>
        public long MaxPairwiseProductFast(int[] ar)
        {
            var index1 = 0;
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > ar[index1])
                {
                    index1 = i;
                }
            }

            var index2 = 0;

            if (index1 == 0)
            {
                index2 = 1;
            }
            
            for (int i = 0; i < ar.Length; i++)
            {
                if (i != index1 && ar[i] > ar[index2])
                {
                    index2 = i;
                }
            }
            
            return (long) ar[index1] * ar[index2];
        }

        /// <summary> main submit-ready </summary>
        /// <param name="args"></param>
        void Main(string[] args)
        {
            var nStr = Console.ReadLine();
            var n = Int32.Parse(nStr);

            var arrStr = Console.ReadLine();
            var tokens = arrStr.Split(' ');
            var ar = new int[n];

            for(int i = 0; i < tokens.Length; i++)
            {
                ar[i] = Int32.Parse(tokens[i]);
            }

            var result = MaxPairwiseProductFast(ar);

            Console.WriteLine(result);
        }
    }
}