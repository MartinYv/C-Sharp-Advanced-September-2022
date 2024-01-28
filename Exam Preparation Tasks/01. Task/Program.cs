using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_cAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeinе = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int caffeinеTaken = 0;

            while (caffeinе.Count != 0 && energyDrinks.Count != 0)
            {
                int miligramsOfCaff =caffeinе.Peek();
                int milligramsOfEDrink = energyDrinks.Peek();



                int sum = miligramsOfCaff * milligramsOfEDrink;

                if (caffeinеTaken + sum <= 300)
                {
                    caffeinеTaken += sum;

                    caffeinе.Pop();
                    energyDrinks.Dequeue();
                }
                else
                {
                    caffeinе.Pop();
                    energyDrinks.Dequeue();
                    energyDrinks.Enqueue(milligramsOfEDrink);
                    caffeinеTaken -= 30;

                    if (caffeinеTaken<0)
                    {
                        caffeinеTaken = 0;
                    }
                }
            }

            if (energyDrinks.Count>0)
            {
            Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");

            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }
            Console.WriteLine($"Stamat is going to sleep with {caffeinеTaken} mg caffeine.");

        }
    }
}
