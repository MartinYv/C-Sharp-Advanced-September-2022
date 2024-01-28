using System;

namespace _03._Car_Constructors
{
	class Program
	{
		static void Main(string[] args)
		{
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            firstCar.WhoAmI();
            Console.WriteLine();

            secondCar.WhoAmI();
            Console.WriteLine();

            thirdCar.WhoAmI();
        }
	}
}
