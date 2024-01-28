using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            //    {[()]}
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();

            bool hasLeft = true;

            for (int i = 0; i < input.Length; i++)
            {

                string curr = input[i].ToString();

                if (curr == "{" || curr == "[" || curr == "(")
                {
                    stack.Push(curr);
                }

                else if (curr == "}" || curr == "]" || curr == ")")
                {

                    if (stack.Count == 0)
                    {
                        hasLeft = false;
                        break;
                    }
                    else if (curr == "}" && stack.Peek() == "{")
                    {
                        stack.Pop();
                    }
                    else if (curr == "]" && stack.Peek() == "[")
                    {
                        stack.Pop();
                    }
                    else if (curr == ")" && stack.Peek() == "(")
                    {
                        stack.Pop();
                    }
                }
            }

            if (hasLeft == true && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
        }
    }
