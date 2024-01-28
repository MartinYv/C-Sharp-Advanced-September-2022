using System;
using System.Collections.Generic;
namespace Stack_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                stack.Push(ch);

            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());

            }

        }
    }
}
