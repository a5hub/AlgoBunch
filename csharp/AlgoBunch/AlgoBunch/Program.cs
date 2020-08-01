using System;

namespace AlgoBunch
{
    class Program
    {
        public static int FibonacciFast(int n, int[] nums)
        {
            if (n <= 1)
                return n;
            if (nums[n - 1] != 0 && nums[n - 2] != 0)
            {
                return nums[n - 1] + nums[n - 2];
            }
            else
            {
                nums[n - 1] = FibonacciFast(n - 1, nums);
                nums[n - 2] = FibonacciFast(n - 2, nums);

                return nums[n - 1] + nums[n - 2];
            }
        }

        public static int FibonacciFastWrapped(int n)
        {
            var nums = new int[n];

            return FibonacciFast(n, nums);
        }

        static void Main(string[] args)
        {
            var nStr = Console.ReadLine();
            var n = Int32.Parse(nStr);

            Console.WriteLine(FibonacciFastWrapped(n));
        }
    }
}
