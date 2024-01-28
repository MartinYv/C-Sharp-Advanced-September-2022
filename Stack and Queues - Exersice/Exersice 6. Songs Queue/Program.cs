using System;
using System.Collections.Generic;

namespace Exersice_6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands.Contains("Play"))
                {
                    queue.Dequeue();
                }

                if (commands.Contains("Add"))
                {
                    string song = commands.Substring(4);
                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }

                if (commands.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }
            }
        }
    }
}
