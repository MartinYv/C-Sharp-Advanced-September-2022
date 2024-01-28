using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfElements = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < countOfElements; i++)
            {
                string[] currElements = Console.ReadLine().Split(" ");

                if (currElements.Length > 1) //elements.UnionWith(currElements);  Добавяме директно масива с елементи в хашсета!
                {

                    for (int k = 0; k < currElements.Length; k++)
                    {
                        string currEl = currElements[k];
                        elements.Add(currEl);
                    }
                }
                else
                {
                    string currEl = currElements[0];
                    elements.Add(currEl);
                }
                }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
