using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string customerName = Console.ReadLine();

            while (customerName != "End")
            {

                if (customerName != "Paid")
                {
                    queue.Enqueue(customerName);
                }

                else if (customerName == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        string name = queue.Dequeue();
                        Console.WriteLine(name);
                    }
                }

                customerName = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}