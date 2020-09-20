using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LC1470ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[nums.Length];

            var j = 0;
            for (int i = 0; i < nums.Length; i+=2)
            {
                result[i] = nums[j];
                j++;
            }

            j = nums.Length / 2;
            for (int i = 1; i < nums.Length; i+=2)
            {
                result[i] = nums[j];
                j++;
            }

            return result;
        }
    }
}
