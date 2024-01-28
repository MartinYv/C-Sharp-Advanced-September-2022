using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mealsInput = Console.ReadLine().Split();

            Queue<string> mealCalories = new Queue<string>(mealsInput);
            Stack<int> daylyCalories = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray()); // 55/100, верни изходи

            Dictionary<string, int> mealsAndCalories = new Dictionary<string, int>();
            mealsAndCalories.Add("salad", 350);
            mealsAndCalories.Add("soup", 490);
            mealsAndCalories.Add("pasta", 680);
            mealsAndCalories.Add("steak", 790);



            while (mealCalories.Count != 0 && daylyCalories.Count != 0)
            {

                int currDayCals = daylyCalories.Peek();


                while (mealCalories.Count != 0)
                {

                    string meal = mealCalories.Dequeue();
                    int mealCals = mealsAndCalories[meal];


                    currDayCals -= mealCals;

                    if (currDayCals == 0)
                    {
                        daylyCalories.Pop();
                    }

                    else if (currDayCals < 0)
                    {
                        daylyCalories.Pop();                      

                        int nextDayCals = 0;
                        if (daylyCalories.TryPeek(out nextDayCals))
                        {
                            daylyCalories.Pop();
                            daylyCalories.Push(nextDayCals - Math.Abs(currDayCals));

                            break;
                        }
                        else
                        {                         
                            break;
                        }
                    }
                }
            }


            if (mealCalories.Count == 0)
            {
                Console.WriteLine($"John had {mealsInput.Length} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", daylyCalories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealsInput.Length - mealCalories.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", mealCalories)}.");
            }

        }
    }
}