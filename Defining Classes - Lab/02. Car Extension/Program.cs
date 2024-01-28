using System;

namespace _02._Car_Extension
{
	class Program
	{
		static void Main(string[] args)
		{
            Car car = new Car();

            car.Make = "Bentley";
            car.Model = "Continental";
            car.Year = 2015;
            car.FuelQuantity = 100;
            car.FuelConsumption = 22;


            while (true)
            {
                car.Drive(double.Parse(Console.ReadLine()));
                car.WhoAmI();
            }
        }
	}
}
