using System.Collections.Generic;
using System.Linq;

namespace HackerRank.InterviewPreparationKit.Arrays
{
    /// <see cref="https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays"/>
    public static class TwoDArrayDs
    {
        public static int Execute()
        {
            int[][] x = 
            {
                new [] { -9, -9, -9, 1, 1, 1 },
                new [] { 0, -9, 0, 4, 3, 2 },
                new [] { -9, -9, -9, 1, 2, 3 },
                new [] { 0, 0, 8, 6, 6, 0 },
                new [] { 0, 0, 0 -2, 0, 0 },
                new [] { 0, 0, 1, 2, 4, 0 }
            };

            int[][] x1 =
            {
                new [] { -1, -1, 0, -9, -2, -2},
                new [] { -2, -1, -6, -8, -2, -5},
                new [] { -1, -1, -1, -2, -3, -4},
                new [] { -1, -9, -2, -4, -4, -5},
                new [] { -7, -3, -3, -2, -9, -9},
                new [] { -1, -3, -1, -2, -4, -5}
            };  

            var result = HourglassSum(x1);

            return result;
        }

        // Complete the hourglassSum function below.
        static int HourglassSum(int[][] arr)
        {
            var hourglassSum = new List<int>();
            for (var i = 1; i <= arr.Length - 1; i++)
            {
                var length = arr[i].Length - 1;
                for (var j = 1; j <= length; j++)
                {
                    if (i > 0 && i < arr.Length - 1 && j > 0 && j < length)
                    {
                        var topLine = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1];
                        var middleLine = arr[i][j];
                        var bottomLine = arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];

                        var sum = topLine + middleLine + bottomLine;
                        hourglassSum.Add(sum);
                    }
                }
            }

            return hourglassSum.Max();
        }
    }
}
