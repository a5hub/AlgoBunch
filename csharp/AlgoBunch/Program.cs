using System;
using System.Collections.Generic;

namespace AlgoBunch
{
    class Program
    {
        private static Dictionary<char, char> parentheses = new Dictionary<char, char>
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };

        public static string CheckBrackets(string expression)
        {
            var brackets = new Stack<char>();
            var numbers = new Stack<int>();

            var position = 0;
            foreach (char s in expression)
            {
                position++;
                if (parentheses.ContainsKey(s))
                {
                    brackets.Push(s);
                    numbers.Push(position);
                }
                else if(parentheses.ContainsValue(s))
                {
                    if (brackets.Count == 0)
                    {
                        return position.ToString();
                    }

                    var top = brackets.Pop();
                    numbers.Pop();
                    if(s != parentheses[top])
                    {
                        return position.ToString();
                    }
                }
            }

            if (brackets.Count != 0)
            {
                return numbers.Pop().ToString();
            }
            
            return "Success";
        }

        static void Main(string[] args)
        {
            while(true)
            {
                var expression = Console.ReadLine();

                var result = CheckBrackets(expression);

                Console.WriteLine(result);
            }
        }
    }
}