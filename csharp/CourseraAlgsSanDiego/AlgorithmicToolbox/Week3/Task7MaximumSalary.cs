using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox.Week3
{
    class Task7MaximumSalary
    {
        private static bool IsGreaterOrEqualForSalary(int a, int b)
        {
            var str1 = new StringBuilder().Append(a.ToString()).Append(b.ToString());
            var str2 = new StringBuilder().Append(b.ToString()).Append(a.ToString());

            return Int32.Parse(str1.ToString()) >= Int32.Parse(str2.ToString());
        }

        private static string Calculate(List<int> numbers)
        {
            var result = new StringBuilder();

            while (numbers.Count > 0)
            {
                var maxNum = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (IsGreaterOrEqualForSalary(numbers[i], maxNum))
                    {
                        maxNum = numbers[i];
                    }
                }

                result.Append(maxNum);
                numbers.Remove(maxNum);
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            var amount = Console.ReadLine();
            var numbersStr = Console.ReadLine().Split(' ').ToList();

            var numbers = new List<int>();
            numbersStr.ForEach(x =>
            {
                numbers.Add(Int32.Parse(x));
            });

            var result = Calculate(numbers);

            Console.WriteLine(result);
        }
    }
}
