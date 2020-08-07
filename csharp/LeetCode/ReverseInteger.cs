using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary> https://leetcode.com/problems/reverse-integer/ </summary>
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            try
            {
                var number = Math.Abs(x);
                var decompose = new List<int>();
                while (number > 0)
                {
                    decompose.Add(number % 10);
                    number /= 10;
                }

                var compose = 0;
                foreach (var d in decompose)
                {
                    compose = checked(compose * 10 + d);
                }

                if (x < 0)
                {
                    compose *= -1;
                }
                
                return compose;
            }
            catch
            {
                return 0;
            }
           
        }
    }
}
