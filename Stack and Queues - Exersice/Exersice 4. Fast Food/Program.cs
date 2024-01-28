using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfTheFood = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));


            Console.WriteLine(queue.Max());

            while (true)
            {
                int order = queue.Peek();

                if (quantityOfTheFood >= order)
                {
                    quantityOfTheFood -= order;
                    queue.Dequeue();                
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine($"Orders complete");
                    break;
                }
                if (quantityOfTheFood < order && queue.Count > 0)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    break;                  
                }


            }

        }
    }
}
