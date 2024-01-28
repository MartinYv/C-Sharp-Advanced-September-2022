using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Action<string> print = name => Console.WriteLine($"Sir {name}");

            names.ForEach(print);
        }
    }
}
