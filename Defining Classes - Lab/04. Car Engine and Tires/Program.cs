using System;

namespace _04._Car_Engine_and_Tires
{
	class Program
	{
		static void Main(string[] args)
		{
			Tyre[] tires = new Tyre[4]
		   {
				new Tyre(1, 2.0),
				new Tyre(1, 2.2),
				new Tyre(2, 2.4),
				new Tyre(2, 2.3)
		   };

			Engine engine = new Engine(507, 5000);

			Car car = new Car("BMW", "M5", 2005, 70, 20, engine, tires);

			Console.WriteLine($"BMW M5 With {car.Engine.HorsePower}hp, {car.Engine.CubicCapacity}cc.");
			Console.WriteLine($"Production year: {car.Year}");
			Console.WriteLine($"Tank capacity: {car.FuelQuantity} with fuel consumption of {car.FuelConsumption}l/100km");
			Console.WriteLine($"Front left tyre: {car.Tyres[0].Pressure:F2}psa, Front right tyre: {car.Tyres[1].Pressure:F2}psa");
			Console.WriteLine($"Rear left tyre: {car.Tyres[2].Pressure:F2}psa, Rear right tyre: {car.Tyres[3].Pressure:F2}psa");
		}
	}
}
