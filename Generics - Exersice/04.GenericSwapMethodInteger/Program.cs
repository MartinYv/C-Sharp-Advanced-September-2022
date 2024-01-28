using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
             Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = swapIndexes[0];
            int secondIndex = swapIndexes[1];

            var list = box.ToList();
            box.Swap(list, firstIndex, secondIndex);

            Console.WriteLine(box.ToString());
        }
    }
    }
}
