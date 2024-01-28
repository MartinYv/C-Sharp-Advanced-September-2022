using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] == "Drive")
            {
                string model = command[1];
                double distance = double.Parse(command[2]);

                foreach (var car in cars.Where(c => c.Model.Equals(model)))
                {
                    car.Drive(model, distance);
                }

                command = Console.ReadLine().Split();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}