using System.Diagnostics;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week6
{
    public class Week6Task1MaximumAmountOfGold
    {
        public int KnapsackWithoutRepetitions(int W, int[] items)
        {
            var n = items.Length;

            var value = new int[W + 1, n + 1];

            for(int i = 1; i <= n; i++)
            {
                for(int w = 1; w <= W; w++)
                {
                    value[w, i] = value[w, i - 1];
                    if(items[i - 1] <= w)
                    {
                        var val = value[w - items[i - 1], i - 1] + items[i - 1];
                        if(value[w, i] < val)
                        {
                            value[w, i] = val;
                        }
                        
                    }
                }
            }

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < W + 1; j++)
                {
                    Debug.Write(value[j, i] + " ");
                }

                Debug.WriteLine(" ");
            }

            return value[W, n];
        }
    }
}