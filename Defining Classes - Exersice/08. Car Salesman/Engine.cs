﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Car_Salesman
{
	class Engine
	{

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; } = 0;
        public string Efficiency { get; set; } = "n/a";

        public Engine()
        {

        }
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }

    }
}
