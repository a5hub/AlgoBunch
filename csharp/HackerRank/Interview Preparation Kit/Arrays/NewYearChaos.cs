using System;

namespace HackerRank.InterviewPreparationKit.Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    /// </summary>
    public static class NewYearChaos
    {
        public static void Execute()
        {
            var arr = new[] { 1, 2, 5, 3, 7, 8, 6, 4 };
            MinimumBribes(arr);
        }

        // Complete the minimumBribes function below.
        static void MinimumBribes(int[] q)
        {
            var bribes = 0;
            for (var i = q.Length - 1; i >= 0 ; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                for (var j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i]) bribes++;
                }
            }

            Console.WriteLine(bribes);
        }
    }
}