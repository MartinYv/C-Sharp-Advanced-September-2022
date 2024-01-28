using System;

namespace _01._Car
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();

			car.Make = "Audi";
			car.Model = "A3";
			car.Year = 2005;

			Console.WriteLine($"Make: {car.Make} \r\nModel: {car.Model} \r\nProduction Year: {car.Year}");
		}
	}
}
