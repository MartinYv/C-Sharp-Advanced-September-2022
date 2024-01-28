using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] currDistanceAndFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(currDistanceAndFuel);
            }

           
            int startPump = 0;
            while (true)
            {
                int totalFuel = 0;
                bool isComplete = true;

                foreach (int[] item in queue)
                {
                    int fuel = item[0];
                    int distance = item[1];

                    totalFuel += fuel;
                    if (totalFuel - distance < 0)
                    {
                        startPump++;
                        isComplete = false;
                       int[] currentPump = queue.Dequeue();
                       queue.Enqueue(currentPump);
                        break;
                    }

                    totalFuel -= distance;
                }

                if (isComplete)
                {
                    Console.WriteLine(startPump);
                    break;
                }

            }
        }
    }
}

