using System;
using System.Collections.Generic;
using System.Threading;

namespace CourseraAlgsSanDiego.DataStructures
{
    public class BasicStack<T>
    {
        private T[] arrayData;
        private const int defaultSize = 30;
        private int index;

        public int Count
        {
            get
            {
                return index;
            }
        }

        public BasicStack()
        {
            arrayData = new T[defaultSize];
            index = 0;
        }
 
        public BasicStack(int size)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", "Size must be a positive number");
 
            arrayData = new T[size];
            index = 0;
        }

        public T Pop()
        {
            if (index == 0)
                throw new InvalidOperationException("Exception: Empty stack");
 
            return arrayData[--index];
 
        }
 
        public T Peek()
        {
            if (index == 0)
                throw new InvalidOperationException("Exception: Empty stack");
 
            return arrayData[index-1];
 
        }
 
        public void Push(T obj)
        {
            if (index == arrayData.Length)
            {
                T[] newArray = new T[2 * arrayData.Length];
                Array.Copy(arrayData, 0, newArray, 0, index);
                arrayData = newArray;
            }
            arrayData[index] = obj;
            index++;
        }
    }

    public class Week1Task1CheckBracketsInTheCode
    {
        private Dictionary<char, char> parentheses = new Dictionary<char, char>
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };

        

        public string CheckBrackets(string expression)
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
    }
}