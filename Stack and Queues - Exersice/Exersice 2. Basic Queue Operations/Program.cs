using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue= new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int countToDeque = nsx[1];
            int elementToLookFor = nsx[2];

            while (true)
            {
                for (int i = 0; i <countToDeque ; i++)
                {
                    queue.Dequeue();
                }

                if (queue.Contains(elementToLookFor))
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Min());
                        break;
                    }
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                    break;
                }

            }
        }
    }
}
