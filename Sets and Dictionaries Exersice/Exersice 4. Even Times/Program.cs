using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbersAndCount = new Dictionary<int, int>();

            for (int i = 0; i < countOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersAndCount.ContainsKey(number))
                {
                    numbersAndCount.Add(number,0);
                }
                numbersAndCount[number]++;
            }

            Console.WriteLine(string.Join(" ", numbersAndCount.Single(x => x.Value % 2 ==0).Key));
        }
    }
}
