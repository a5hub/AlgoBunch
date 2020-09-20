using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LeetCode
{
    public class LC1582SpecialPositionsInABinaryMatrix
    {
        public int NumSpecial(int[][] mat)
        {
            var result = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        var summ = 0;
                        for (int k = 0; k < mat[i].Length; k++)
                        {
                            summ += mat[i][k];
                        }

                        for (int l = 0; l < mat.Length; l++)
                        {
                            summ += mat[l][j];
                        }

                        summ -= mat[i][j];

                        if(summ == 1)
                        {
                            result++;
                        }

                        break;
                    }
                    
                }
            }
            
            return result;
        }
    }
}
