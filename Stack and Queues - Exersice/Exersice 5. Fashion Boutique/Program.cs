using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            
            int takenCapacity = 0;
            int racksNeeded = 0;

            while (stack.Count > 0)
            {
                int currBox = stack.Pop();
                takenCapacity += currBox;

                if (takenCapacity < rackCapacity)
                {
                    continue;
                }

                if (takenCapacity == rackCapacity && stack.Count > 0)
                {
                    racksNeeded++;
                    takenCapacity = 0;

                }
                if (takenCapacity > rackCapacity)
                {
                    racksNeeded++;
                    takenCapacity = 0;
                    takenCapacity += currBox;
                }
            }

            if (takenCapacity > 0)
            {
                racksNeeded++;
            }

            Console.WriteLine(racksNeeded);
        }
    }
}
