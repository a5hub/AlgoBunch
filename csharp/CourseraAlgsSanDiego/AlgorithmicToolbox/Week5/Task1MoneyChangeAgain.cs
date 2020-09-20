using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week5
{
    class Task1MoneyChangeAgain
    {
        //1, 3, 4
        public static int Calculate(int money, int[] coins)
        {
            var MinNumCoins = new Dictionary<int, int> {[0] = 0};

            for (int m = 1; m <= money; m++)
            {
                MinNumCoins.Add(m, int.MaxValue);
                for (int i = 0; i < coins.Length; i++)
                {
                    if (m >= coins[i])
                    {
                        var NumCoins = MinNumCoins[m - coins[i]] + 1;
                        if (NumCoins < MinNumCoins[m])
                        {
                            MinNumCoins[m] = NumCoins;
                        }
                    }
                }
            }

            return MinNumCoins[money];
        }
        
        static void Main(string[] args)
        {
            var money = Int32.Parse(Console.ReadLine());
            var coins = new int[] {1, 3, 4};

            Console.WriteLine(Calculate(money, coins));
        }
    }
}