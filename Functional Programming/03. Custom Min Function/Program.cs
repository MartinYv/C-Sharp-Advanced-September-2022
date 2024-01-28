using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToList();

            Func<List<int>, int> smallestNum = number => numbers.Min();

            Console.WriteLine(smallestNum(numbers));

        }
    }
}
