using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);

                if (stack.Count == 3)
                {
                    int first = int.Parse(stack.Pop());
                    var sighn = stack.Pop();
                    var second = int.Parse(stack.Pop());
                    int result = 0;

                    if (sighn == "+")
                    {
                        result = first + second;
                    }

                    else
                    {
                        result = second - first;
                    }

                    stack.Push(result.ToString());

                }
            }
            Console.WriteLine(stack.Peek());

        }
    }
}