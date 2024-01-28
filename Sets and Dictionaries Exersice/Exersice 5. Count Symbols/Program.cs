using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> ocurrence = new SortedDictionary<char, int>();
            string text = Console.ReadLine();


            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];

                if (!ocurrence.ContainsKey(currChar))
                {
                    ocurrence.Add(currChar, 0);
                }
                ocurrence[currChar]++;
            }

            foreach (var currCh in ocurrence)
            {
                Console.WriteLine($"{currCh.Key}: {currCh.Value} time/s");
            }
        }
    }
}
