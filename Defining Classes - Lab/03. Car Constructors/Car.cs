using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Car_Constructors
{
	class Car
	{
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

       
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double fuel = FuelQuantity - (distance * FuelConsumption);

            if (fuel < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
            else
            {
                FuelQuantity = fuel;
                Console.WriteLine($"You have {FuelQuantity:f2} left in the tank.");
            }
        }

        public void WhoAmI()
        {
            Console.WriteLine($"Make: {this.Make} " +
                $"\r\nModel: {this.Model} " +
                $"\r\nYear: {this.Year}" +
                $"\r\nFuel: {this.FuelQuantity:f2}");
        }
    }
}
