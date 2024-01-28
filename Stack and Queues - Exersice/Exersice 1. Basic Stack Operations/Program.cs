using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int numberToPush = nsx[0];
            int numberToPop = nsx[1];
            int numberToLookFor = nsx[2];

            while (true)
            {
                for (int i = 0; i < numberToPop; i++)
                {
                    stack.Pop();
                }

                if (stack.Contains(numberToLookFor))
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    if (stack.Count > 0)
                    {
                    Console.WriteLine(stack.Min());
                    break;

                    }
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                    break;
                }
            }
           
        }
    }
}
