using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week5
{
    public class Task4LongestCommonSubsequenceOfTwo
    {
        public Tuple<int[][], int> EditDistance<T>(List<T> A, List<T> B)
        {
            var n = A.Count;
            var m = B.Count;

            var d = new int[n][];
            for (int i = 0; i < n; i++)
            {
                d[i] = new int[m];
                d[i][0] = i;
            }
            for (int i = 0; i < m; i++)
            {
                d[0][i] = i;
            }

            var matcher = 0;
            var lastIndex = 0;
            for (int j = 1; j < m; j++)
            {
                T lastNum = default(T);
                for (int i = 1; i < n; i++)
                {
                    var insert = d[i][j - 1] + 1;
                    var delete = d[i - 1][j] + 1;
                    var match = d[i - 1][j - 1];
                    var mismatch = d[i - 1][j - 1] + 1;

                    if (A[i].Equals(B[j]))
                    {
                        d[i][j] = Math.Min(insert, Math.Min(delete, match));
                        if(lastIndex < i && !lastNum.Equals(A[i]))
                        {
                            lastNum = A[i];
                            lastIndex = i;
                            matcher++;
                        }
                    }
                    else
                    {
                        d[i][j] = Math.Min(insert, Math.Min(delete, mismatch));
                    }
                }
            }
            
            return Tuple.Create(d, matcher);
        }

        void Main(string[] args)
        {
            var sequence1Length = Int32.Parse(Console.ReadLine());
            var sequence1Str = Console.ReadLine().Split(' ');

            var sequence2Length = Int32.Parse(Console.ReadLine());
            var sequence2Str = Console.ReadLine().Split(' ');

            var word1 = new List<int>();
            word1.Add(0);
            foreach (var s in sequence1Str)
            {
                word1.Add(Int32.Parse(s));
            }

            var word2 = new List<int>();
            word2.Add(0);
            foreach (var s in sequence2Str)
            {
                word2.Add(Int32.Parse(s));
            }

            var result = EditDistance(word1, word2);

            Console.WriteLine(result.Item2);
        }
    }
}
