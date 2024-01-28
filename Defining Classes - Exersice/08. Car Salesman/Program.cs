using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Car_Salesman
{
	class Program
	{
		static void Main(string[] args)
		{
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine engine = new Engine(model, power);

                if (engineInfo.Length == 3 && char.IsDigit(engineInfo[2][0]))
                {
                    engine.Displacement = int.Parse(engineInfo[2]);
                }
                if (engineInfo.Length == 3 && char.IsLetter(engineInfo[2][0]))
                {
                    engine.Efficiency = engineInfo[2];
                }
                if (engineInfo.Length == 4)
                {
                    engine.Displacement = int.Parse(engineInfo[2]);
                    engine.Efficiency = engineInfo[3];
                }

                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];

                Engine engine = new Engine();

                foreach (var e in engines.Where(e => e.Model == carInfo[1]))
                {
                    engine = new Engine(e.Model, e.Power, e.Displacement, e.Efficiency);
                }

                Car car = new Car(model, engine);

                if (carInfo.Length == 3 && char.IsDigit(carInfo[2][0]))
                {
                    car.Weight = int.Parse(carInfo[2]);
                }
                if (carInfo.Length == 3 && char.IsLetter(carInfo[2][0]))
                {
                    car.Color = carInfo[2];
                }
                else if (carInfo.Length == 4)
                {
                    car.Weight = int.Parse(carInfo[2]);
                    car.Color = carInfo[3];
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.Write(car.ToString());
            }
        }
	}
}
