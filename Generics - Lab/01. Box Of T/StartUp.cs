using System;
using System.Collections.Generic;

namespace BoxOfT
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            Box<int> box = new Box<int>();

            box.Add(1);
            box.Add(2);
            box.Remove();
            box.Add(33);
            Console.WriteLine(box.Count);
        }
    }
}
