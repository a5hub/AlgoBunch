using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseraAlgsSanDiego.AlgorithmicToolbox
{
    class Week4Task2MajorityElement
    {
        /* Function to find the candidate for Majority */
        static int findCandidate(List<int> a, int size)  
        { 
            int maj_index = 0, count = 1; 
            int i; 
            for (i = 1; i < size; i++)  
            { 
                if (a[maj_index] == a[i]) 
                    count++; 
                else
                    count--; 
                  
                if (count == 0) 
                { 
                    maj_index = i; 
                    count = 1; 
                } 
            } 
            return a[maj_index]; 
        } 

        // Function to check if the candidate  
        // occurs more than n/2 times 
        static bool isMajority(List<int> a, int size, int cand)  
        { 
            int i, count = 0; 
            for (i = 0; i < size; i++)  
            { 
                if (a[i] == cand) 
                    count++; 
            } 
            if (count > size / 2)  
                return true; 
            else
                return false; 
        } 

        private static int Calculate(List<int> numbers)
        {
            var size = numbers.Count;
            /* Find the candidate for Majority*/
            int cand = findCandidate(numbers, size); 
  
            /* Print the candidate if it is Majority*/
            if (isMajority(numbers, size, cand)) 
                return 1; 
            else
                return 0; 
        }

        static void Main(string[] args)
        {
            var numberCount = Int32.Parse(Console.ReadLine());
            var numbersStr = Console.ReadLine().Split(' ').ToList();

            var numbers = new List<int>();
            for (int i = 0; i < numberCount; i++)
            {
                numbers.Add(Int32.Parse(numbersStr[i]));
            }

            var result = Calculate(numbers);

            Console.WriteLine(result);
        }
    }
}
