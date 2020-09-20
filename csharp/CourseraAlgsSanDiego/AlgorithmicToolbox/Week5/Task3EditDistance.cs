using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week5
{
    class Task3EditDistance
    {
         public static int[][] EditDistance(List<char> A, List<char> B)
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

            for (int j = 1; j < m; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    var insert = d[i][j - 1] + 1;
                    var delete = d[i - 1][j] + 1;
                    var match = d[i - 1][j - 1];
                    var mismatch = d[i - 1][j - 1] + 1;

                    if (A[i] == B[j])
                    {
                        d[i][j] = Math.Min(insert, Math.Min(delete, match));
                    }
                    else
                    {
                        d[i][j] = Math.Min(insert, Math.Min(delete, mismatch));
                    }
                }
            }


            return d;
        }
        
        static void Main(string[] args)
        {
            var word1Str = Console.ReadLine();
            var word2Str = Console.ReadLine();

            var word1 = new List<char>();
            word1.Add(' ');
            foreach (var s in word1Str)
            {
                word1.Add(s);
            }

            var word2 = new List<char>();
            word2.Add(' ');
            foreach (var s in word2Str)
            {
                word2.Add(s);
            }

            var result = EditDistance(word1, word2);

            Console.WriteLine(result[word1.Count-1][word2.Count-1]);

            //for (int i = 0; i < word1.Count; i++)
            //{
            //    for (int j = 0; j < word2.Count; j++)
            //    {
            //        Console.Write(result[i][j] + " ");
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
