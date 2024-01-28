using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Special_Cars
{
	class Program
	{
		static void Main(string[] args)
		{
            string[] tyreInfo = Console.ReadLine().Split();

            var tyresList = new List<Tyre[]>();
            var enginesList = new List<Engine>();
            var carsList = new List<Car>();

            while (tyreInfo[0] != "No")
            {
                Tyre[] tires = new Tyre[]
                {
                    new Tyre(int.Parse(tyreInfo[0]), double.Parse(tyreInfo[1])),
                    new Tyre(int.Parse(tyreInfo[2]), double.Parse(tyreInfo[3])),
                    new Tyre(int.Parse(tyreInfo[4]), double.Parse(tyreInfo[5])),
                    new Tyre(int.Parse(tyreInfo[6]), double.Parse(tyreInfo[7]))
                };

                tyresList.Add(tires);

                tyreInfo = Console.ReadLine().Split().ToArray();
            }

            string[] engineInfo = Console.ReadLine().Split();

            while (engineInfo[0] != "Engines")
            {
                Engine engine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));

                enginesList.Add(engine);

                engineInfo = Console.ReadLine().Split();
            }

            string[] carInfo = Console.ReadLine().Split();

            while (carInfo[0] != "Show")
            {
                int engineIndex = int.Parse(carInfo[5]);
                int tyreIndex = int.Parse(carInfo[6]);

                Car car = new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2]),
                    double.Parse(carInfo[3]), double.Parse(carInfo[4]),
                    enginesList[engineIndex], tyresList[tyreIndex]);

                carsList.Add(car);

                carInfo = Console.ReadLine().Split();
            }

            Func<Car, bool> func = (car) => car.Year >= 2017 && car.Engine.HorsePower > 330 &&
            car.Tyres.Sum(t => t.Pressure) >= 9 && car.Tyres.Sum(t => t.Pressure) <= 10;

            foreach (var car in carsList.Where(func))
            {
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
	}
}
