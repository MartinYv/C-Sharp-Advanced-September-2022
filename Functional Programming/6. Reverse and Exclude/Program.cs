using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numToDivide = int.Parse(Console.ReadLine());

            Predicate<int> isDevidable = number => number % numToDivide == 0;
            
          numbers.Reverse();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (isDevidable(numbers[i]))
                {       
                numbers.Remove(numbers[i]);
                    i--;
                }
            }

            Action<List<int>> print = number => Console.Write(string.Join(" ", numbers));
            print(numbers);
        }
    }
}
