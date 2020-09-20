using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    class Week5Task2PrimitiveCalculator
    {
        // +1, x2, x3
        public static Dictionary<int, Tuple<int, int>> Calculate(int number)
        {
            var mults = new [] {1, 2, 3};
            var minNum = new Dictionary<int, Tuple<int, int>> {[0] = Tuple.Create(0, 0)};

            for (int m = 1; m <= number; m++)
            {
                minNum.Add(m, Tuple.Create(int.MaxValue, int.MaxValue));
                foreach (var t in mults)
                {
                    if (m >= t)
                    {
                        if (m % t == 0 && t != 1)
                        {
                            var numCoins = 1;
                            if(m != t)
                            {
                                 numCoins = minNum[m / t].Item1 + 1;
                            }
                            if (numCoins < minNum[m].Item1)
                            {
                                minNum[m] = Tuple.Create(numCoins, t);
                            }
                        }
                        else if(t == 1)
                        {
                            if (m == t)
                            {
                                minNum[m] = Tuple.Create(0, 1);
                                continue;
                            }
                            var numCoins = minNum[m - t].Item1 + 1;
                            if (numCoins < minNum[m].Item1)
                            {
                                minNum[m] = Tuple.Create(numCoins, t);
                            }
                        }
                    }
                }
            }

            return minNum;
        }
        
        static void Main(string[] args)
        {
            var number = Int32.Parse(Console.ReadLine());

            var result = Calculate(number);

            var resultList = new List<int>();

            var x = result.Count - 1;
            while(x > 0)
            {
                resultList.Add(x);
                if (result[x].Item2 == 1)
                {
                    x--;
                }
                else
                {
                    x = x / result[x].Item2;
                }
            }

            resultList.Sort();

            Console.WriteLine(result[number].Item1);
            foreach (var r in resultList)
            {
                Console.Write(r + " ");
            }

            Console.WriteLine();
        }
    }
}