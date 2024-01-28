using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "add")
                {
                    Func<List<int>, List<int>> add = number => number.Select(number => number += 1).ToList() ;
                    numbers = add(numbers);
                }

                else if (input == "multiply")
                {
                    Func<List<int>, List<int>> multiply = list => list.Select(number => number *= 2).ToList();
                    numbers = multiply(numbers);
                }

                else if (input == "subtract")
                {
                    Func<List<int>, List<int>> subtract = list => list.Select(number => number -= 1).ToList();
                    numbers = subtract(numbers);
                }

                else if (input == "print")
                {
                    Action<List<int>> print = list => Console.Write(string.Join(" ", list));
                    print(numbers);
                }

                input = Console.ReadLine();
            }
        }

    }
}
