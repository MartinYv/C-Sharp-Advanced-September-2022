using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] minMax = Console.ReadLine().Split();
            int minRange = int.Parse(minMax[0]);
            int maxRange = int.Parse(minMax[1]);
            
            string command = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<int> newNumbers = new List<int>();

            Predicate<int> IsEven = number => number % 2 == 0;

            for (int i = minRange; i <= maxRange; i++)
            {
                numbers.Add(i);
            }



            if (command == "even")
            {

                for (int i = 0; i < numbers.Count; i++)
                {
                  
                    if (IsEven(numbers[i]))
                    {
                    newNumbers.Add(numbers[i]);
                    }
                }
            }

            else
            {

                for (int i = 0; i < numbers.Count; i++)
                {
                   
                    if (!IsEven(numbers[i]))
                    {
                    newNumbers.Add(numbers[i]);
                    }
                }
            }

            Console.Write(string.Join(" ",newNumbers));
        }
    }
}
