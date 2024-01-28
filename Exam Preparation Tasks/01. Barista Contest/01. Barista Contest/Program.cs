using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Barista_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffee = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Stack<int> milk = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Dictionary<string, KeyValuePair<int, int>> drinksToDo = new Dictionary<string, KeyValuePair<int, int>>();
            drinksToDo.Add("Cortado", new KeyValuePair<int, int>(50, 0));
            drinksToDo.Add("Espresso", new KeyValuePair<int, int>(75, 0));
            drinksToDo.Add("Capuccino", new KeyValuePair<int, int>(100, 0));
            drinksToDo.Add("Americano", new KeyValuePair<int, int>(150, 0));
            drinksToDo.Add("Latte", new KeyValuePair<int, int>(200, 0));

            while (coffee.Count != 0 && milk.Count != 0)
            {
                int coffeeValue = coffee.Dequeue();
                int milkValue = milk.Pop();
                int sum = coffeeValue + milkValue;


                if (drinksToDo.Any(x => x.Value.Key == sum))
                {
                    var drink = drinksToDo.First(x => x.Value.Key == sum);
                    var key = drink.Key;
                    drinksToDo[key] = new KeyValuePair<int, int>(drink.Value.Key, drink.Value.Value + 1);
                }
                else
                {
                    milk.Push(milkValue - 5);
                }
            }


            if (milk.Count == 0 && coffee.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            string coffeeLeft = coffee.Count == 0 ? "Coffee left: none" : $"Coffee left: {string.Join(" ", coffee)}";
            string milkLeft = milk.Count == 0 ? "Milk left: none" : $"Milk left: {string.Join(" ", milk)}";

            Console.WriteLine(coffeeLeft);
            Console.WriteLine(milkLeft);


            foreach (var item in drinksToDo.Where(x => x.Value.Value > 0).OrderBy(x => x.Value.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Value}");
            }
        }
    }
}