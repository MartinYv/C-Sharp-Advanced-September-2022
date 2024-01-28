using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split().Select(double.Parse).ToList());
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split().Select(double.Parse).ToList());


            Dictionary<string,int> bakery = new Dictionary<string, int>
            {
                {"Croissant", 0 },                   // 50-50
                {"Muffin", 0 },                      // 40-60
                {"Bagel", 0 },                       // 30-70
                {"Baguette", 0 },                    // 20-80
            };                                      

            while (water.Count!= 0 && flour.Count!=0)
            {
                double currWater = water.Dequeue();
                double currFlour = flour.Pop();   

                double devider = currWater + currFlour;

                double waterPercentage = (currWater * 100) / devider;          //(16.8 + 25.2 = 42; (16.8 * 100)/42 = 40% water    
                double flourPercentage = currFlour * 100 / devider;

                if (waterPercentage == 50 && flourPercentage == 50)
                {
                    bakery["Croissant"]++;
                }

                else if (waterPercentage == 40 && flourPercentage == 60)
                {
                    bakery["Muffin"]++;
                }

                else if (waterPercentage == 30 && flourPercentage == 70)
                {
                    bakery["Baguette"]++;
                }

                else if (waterPercentage == 20 && flourPercentage == 80)
                {
                    bakery["Bagel"]++;
                }

                else
                {
                    double result = currFlour - currWater;
                    flour.Push(result);
                    bakery["Croissant"]++;
                }


            }
            foreach (var item in bakery.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            string waterLeft = water.Count == 0 ? "Water left: None" : $"Water left: {string.Join(", ", water)}";
            string flourLeft = flour.Count == 0 ? "Flour left: None" : $"Flour left: {string.Join(", ", flour)}";

            Console.WriteLine(waterLeft);
            Console.WriteLine(flourLeft);
        }
    }
}
