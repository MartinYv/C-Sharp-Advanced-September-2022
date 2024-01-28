using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string info = Console.ReadLine();

            while (true)
            {
                string[] command = info.ToLower().Split();

                if (command[0]== "end")
                {
                    break;
                }

                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                if (command[0] == "remove")
                {
                    int numbersToRemove = int.Parse(command[1]);

                    if (stack.Count >= numbersToRemove)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                info = Console.ReadLine();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}

