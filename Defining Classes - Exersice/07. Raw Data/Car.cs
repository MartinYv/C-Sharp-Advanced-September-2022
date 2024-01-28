using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
	class Car
	{
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tyre[] Tyres { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tyre[] tyres)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tyres = tyres;
        }
     
    }
}
