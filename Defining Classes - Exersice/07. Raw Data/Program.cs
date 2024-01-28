using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
	class Program
	{
		static void Main(string[] args)
		{
			var cars = new List<Car>();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] carInfo = Console.ReadLine().Split();

				string model = carInfo[0];
				int engineSpeed = int.Parse(carInfo[1]);
				int enginePower = int.Parse(carInfo[2]);
				int cargoWeight = int.Parse(carInfo[3]);
				string cargoType = carInfo[4];

				double tyre1Pressure = double.Parse(carInfo[5]);
				int tyre1Age = int.Parse(carInfo[6]);

				double tyre2Pressure = double.Parse(carInfo[7]);
				int tyre2Age = int.Parse(carInfo[8]);

				double tyre3Pressure = double.Parse(carInfo[9]);
				int tyre3Age = int.Parse(carInfo[10]);

				double tyre4Pressure = double.Parse(carInfo[11]);
				int tyre4Age = int.Parse(carInfo[12]);

				Engine engine = new Engine
				{
					Power = enginePower,
					Speed = engineSpeed
				};

				Cargo cargo = new Cargo
				{
					Weight = cargoWeight,
					Type = cargoType
				};

				Tyre[] tyres = new Tyre[]
				{
					new Tyre(tyre1Age, tyre1Pressure),
					new Tyre(tyre2Age, tyre2Pressure),
					new Tyre(tyre3Age, tyre3Pressure),
					new Tyre(tyre4Age, tyre4Pressure)
				};

				Car car = new Car(model, engine, cargo, tyres);

				cars.Add(car);
			}

			string input = Console.ReadLine();

			Func<Car, bool> flammable = (car) => car.Engine.Power > 250 && car.Cargo.Type == "flammable";

			Func<Car, bool> fragile = (car) => car.Tyres.Any(t => t.Pressure < 1);

			if (input == "flammable")
			{
				foreach (var car in cars.Where(flammable))
				{
					Console.WriteLine(car.Model);
				}
			}
			else
			{
				foreach (var car in cars.Where(fragile))
				{
					Console.WriteLine(car.Model);
				}

			}
		}
	}
}