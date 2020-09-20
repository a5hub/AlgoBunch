using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    public class Week3Task1MoneyChange
    {
        private static int Calculate(int n)
        {
            return n / 10 + n % 10 / 5 + n % 5;
        }
        
        static void Main(string[] args)
        {
            var nStr = Console.ReadLine();
            var n = Int32.Parse(nStr);
        
            var result = Calculate(n);
        
            Console.WriteLine(result); 
        }
    }

}
