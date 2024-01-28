using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder stringBuilder = new StringBuilder();

            stack.Push(stringBuilder.ToString());

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string[] command = Console.ReadLine().Split();


                if (command[0] == "1")
                {
                    stringBuilder.Append(command[1]);
                    stack.Push(stringBuilder.ToString());
                }

                else if (command[0] == "2")
                {
                    int remove = int.Parse(command[1]);
                    stringBuilder.Remove(stringBuilder.Length - remove, remove);

                    stack.Push(stringBuilder.ToString());

                }

                else if (command[0] == "3")
                {
                    int indexToRemove = int.Parse(command[1]);
                    Console.WriteLine(stringBuilder[indexToRemove - 1]);
                }
                else if (command[0] == "4")
                {
                    stack.Pop();
                    stringBuilder = new StringBuilder();
                    stringBuilder.Append(stack.Peek());
                }
            }
        }
    }
}