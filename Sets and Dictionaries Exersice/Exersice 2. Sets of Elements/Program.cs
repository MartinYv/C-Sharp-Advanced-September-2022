using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghtForSets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();


            for (int i = 0; i < lenghtForSets[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int k = 0; k < lenghtForSets[1]; k++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            firstSet.IntersectWith(secondSet);

            foreach (var number in firstSet)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
