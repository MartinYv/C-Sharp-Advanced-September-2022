using System;
using System.Collections.Generic;

namespace Exersice_06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] currClothes = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = currClothes[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int k = 1; k < currClothes.Length; k++)
                {
                    if (!wardrobe[color].ContainsKey(currClothes[k]))
                    {
                        wardrobe[color].Add(currClothes[k], 0);
                    }

                wardrobe[color][currClothes[k]]++;
                }
            }

            string[] itemToFind = Console.ReadLine().Split();
            string colorToFind = itemToFind[0];
            string cloth = itemToFind[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var currCloth in color.Value)
                {
                    string printItem = $"* {currCloth.Key} - {currCloth.Value}";
                    if (color.Key == colorToFind && cloth == currCloth.Key)
                    {
                        printItem += " (found!)";
                    }
                    Console.WriteLine(printItem);
                }
            }

        }

    }
}

