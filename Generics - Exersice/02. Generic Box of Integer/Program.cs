using Box;
using System;
using System.Collections.Generic;

namespace BoxOfInt
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> list = new List<Box<int>>();
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                int input = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(input);
                list.Add(box);
            }

            foreach (Box<int> box in list)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
