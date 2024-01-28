using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] whitesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] graysInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> whiteTiles = new Stack<int>(whitesInput);
            Queue<int> greyTiles = new Queue<int>(graysInput);

            Dictionary<string, KeyValuePair<int, int>> locations = new Dictionary<string, KeyValuePair<int, int>>();
            locations.Add("Sink", new KeyValuePair<int, int>(40, 0));
            locations.Add("Oven", new KeyValuePair<int, int>(50, 0));
            locations.Add("Countertop", new KeyValuePair<int, int>(60, 0));
            locations.Add("Wall", new KeyValuePair<int, int>(70, 0));
            locations.Add("Floor", new KeyValuePair<int, int>(0, 0));

            while (whiteTiles.Count != 0 && greyTiles.Count != 0)
            {

                int white = whiteTiles.Pop();
                int gray = greyTiles.Dequeue();

                if (white == gray)
                {
                    int newTail = white + gray;
                    var element = locations.FirstOrDefault(x => x.Value.Key == newTail);

                    if (element.Key != null)
                    {
                        var elementKey = element.Key;
                        locations[elementKey] = new KeyValuePair<int, int>(locations[elementKey].Key, locations[elementKey].Value + 1);
                    }

                    else
                    {
                        locations["Floor"] = new KeyValuePair<int, int>(0, locations["Floor"].Value + 1);

                    }

                }
                else
                {
                    whiteTiles.Push(white / 2);
                    greyTiles.Enqueue(gray);
                }
            }


            string whitesLeft = whiteTiles.Count == 0 ? "none" : string.Join(", ", whiteTiles);
            string greysLeft = greyTiles.Count == 0 ? "none" : string.Join(", ", greyTiles);
            Console.WriteLine($"White tiles left: {whitesLeft}");
            Console.WriteLine($"Grey tiles left: {greysLeft}");


            foreach (var item in locations.Where(x => x.Value.Value > 0).OrderByDescending(x => x.Value.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Value}");
            }

        }
    }
}