using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public static class TwoSums
    {
        public static int[] Execute()
        {
            var arr = new[] { 3, 3};
            return TwoSumNaive(arr, 9);
        }

        public static int[] TwoSumNaive(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new [] {i, j};
                }
            }

            return new int[0];
        }

        public static int[] TwoSumDictHashTable(int[] nums, int target)
        {
            var table = new Hashtable();
            table[nums[0]] = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (table.Contains(diff))
                {
                    return new int[2] { (int)table[diff], i };
                }

                var origin = target - diff;
                if (!table.Contains(origin))
                {
                    table[origin] = i;
                }
            }

            return null;
        }

        public static int[] TwoSumDictionary(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i])) // checks if compliment is in dict
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else if (!dict.ContainsKey(nums[i])) // handles duplicates in array
                {
                    dict.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
