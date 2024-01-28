using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Car_Salesman
{
	class Car
	{
		public string Model { get; set; }
		public Engine Engine { get; set; }
		public int Weight { get; set; } = 0;
		public string Color { get; set; } = "n/a";


		public Car(string model, Engine engine)
		{
			this.Model = model;
			this.Engine = engine;
		}
		public Car(string model, Engine engine, string color) : this(model, engine)
		{
			this.Color = color;
		}
		public Car(string model, Engine engine, int weight) : this(model, engine)
		{
			this.Weight = weight;
		}

		public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
		{
			this.Color = color;
		}

		public override string ToString()
		{
			var stringBuilder = new StringBuilder();

			stringBuilder.AppendLine($"{Model}:");
			stringBuilder.AppendLine($"  {Engine.Model}:");
			stringBuilder.AppendLine($"    Power: {Engine.Power}");

			if (Engine.Displacement != 0)
			{
				stringBuilder.AppendLine($"    Displacement: {Engine.Displacement}");
			}
			else
			{
				stringBuilder.AppendLine($"    Displacement: n/a");
			}

			stringBuilder.AppendLine($"    Efficiency: {Engine.Efficiency}");

			if (Weight != 0)
			{
				stringBuilder.AppendLine($"  Weight: {Weight}");
			}
			else
			{
				stringBuilder.AppendLine($"  Weight: n/a");
			}

			stringBuilder.AppendLine($"  Color: {Color}");

			return stringBuilder.ToString();
		}
	}
}