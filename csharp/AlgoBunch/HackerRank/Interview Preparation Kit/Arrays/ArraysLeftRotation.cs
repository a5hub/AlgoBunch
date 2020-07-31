namespace HackerRank.InterviewPreparationKit.Arrays
{
    /// <remarks>https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays</remarks>
    public static class ArraysLeftRotation
    {
        public static int[] Execute()
        {
            var a = new[] {1, 2, 3, 4, 5};
            var b = 2;

            var result = RotLeft(a, b);

            return result;
        }

        // Complete the rotLeft function below.
        static int[] RotLeft(int[] a, int d)
        {
            var b = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                var ind = (i + d) % a.Length;
                b[i] = a[ind];
            }

            return b;
        }
    }
}
