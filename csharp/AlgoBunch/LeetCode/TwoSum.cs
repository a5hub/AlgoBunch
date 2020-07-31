using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public static class TwoSums
    {
        public static void Execute()
        {
            var arr = new[] { 3, 2, 3 };
            TwoSum(arr, 6);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i] + nums[i + 1] == target)
                {
                    result.Add(i);
                    result.Add(i + 1);
                    i++;
                }
            }

            return result.ToArray();
        }
    }
}
