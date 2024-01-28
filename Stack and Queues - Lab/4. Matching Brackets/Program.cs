﻿using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                
                if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                     string substring = input.Substring(startIndex, endIndex - startIndex + 1);

                    Console.WriteLine(substring);
                }
            }

        }
    }
}
