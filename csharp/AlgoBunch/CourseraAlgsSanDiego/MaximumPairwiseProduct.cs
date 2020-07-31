using System;

namespace CourseraAlgsSanDiego
{
    public class MaximumPairwiseProduct
    {
        public long MaxPairwiseProductNaive(int[] arr)
        {
            long result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    result = Math.Max(result, (long) arr[i] * arr[j]);
                }
            }

            return result;
        }

        public long MaxPairwiseProductFast(int[] ar)
        {
            var index1 = 0;
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > ar[index1])
                {
                    index1 = i;
                }
            }-

            var index2 = 0;

            if (index1 == 0)
            {
                index2 = 1;
            }
            
            for (int i = 0; i < ar.Length; i++)
            {
                if (i != index1 && ar[i] > ar[index2])
                {
                    index2 = i;
                }
            }
            
            return (long) ar[index1] * ar[index2];
        }
    }
}