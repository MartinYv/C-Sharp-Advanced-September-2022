using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Car_Engine_and_Tires
{
	class Tyre
	{
		public int Year { get; set; }
		public double Pressure { get; set; }

		public Tyre(int year, double pressure)
		{
			this.Year = year;
			this.Pressure = pressure;
		}

	}
}
