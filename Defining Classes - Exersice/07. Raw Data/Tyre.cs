﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
	class Tyre
	{
		public int Age { get; set; }
		public double Pressure { get; set; }

		public Tyre(int age, double pressure)
		{
			this.Age = age;
			this.Pressure = pressure;
		}
	}
}
