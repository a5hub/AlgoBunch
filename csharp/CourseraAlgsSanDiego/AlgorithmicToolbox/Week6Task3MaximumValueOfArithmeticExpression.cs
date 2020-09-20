using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Math;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    public class Week6Task3MaximumValueOfArithmeticExpression
    {
        public static long ApplyOperation(long a, long b, char op)
        {
            switch (op)
            {
                case '+':  
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                default:
                    throw new InvalidOperationException($"No such operation {op}");
            }
        }

        public static void MinAndMax(long[,] m, long[,] M, int i, int j, List<char> operations)
        {
            var min = long.MaxValue;
            var max = long.MinValue;

            for (int k = i; k < j; k++)
            {
                var a = ApplyOperation(M[i, k], M[k + 1, j], operations[k]);
                var b = ApplyOperation(M[i, k], m[k + 1, j], operations[k]);
                var c = ApplyOperation(m[i, k], M[k + 1, j], operations[k]);
                var d = ApplyOperation(m[i, k], M[k + 1, j], operations[k]);
                min = Min(min, Min(a, Min(b, Min(c, d))));
                max = Max(max, Max(a, Max(b, Max(c, d))));
            }

            m[i, j] = min;
            M[i, j] = max;
        }

        public static long Parentheses(List<int> numbers, List<char> operation)
        {
            var size = numbers.Count;
            var m = new long[size, size];
            for (int i = 0; i < size; i++)
            {
                m[i, i] = numbers[i];
            }

            var M = new long[size, size];
            for (int i = 0; i < size; i++)
            {
                M[i, i] = numbers[i];
            }

            for (int s = 1; s < size; s++)
            {
                for(int i = 0; i < size - s; i++)
                {
                    var j = i + s;
                    MinAndMax(m, M, i, j, operation);
                }
            }

            return M[0, size - 1];
        }

        public static long ExecuteExpression(string expression)
        {
            var numbers = new List<int>();
            var operation = new List<char>();
            foreach (var s in expression)
            {
                var number = 0;
                if (Int32.TryParse(s.ToString(), out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    operation.Add(s);
                }
            }

            var result = Parentheses(numbers, operation);

            return result;
        }

        static void Main(string[] args)
        {
            while(true)
            {
                var expression = Console.ReadLine();

                var result = ExecuteExpression(expression);

                Console.WriteLine(result);
            }
        }
    }
}
