using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TravelledDistance { get; set; }

        public Car()
        {

        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer) : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKilometer;
        }

        
        public void Drive(string model, double distance)
        {
            double fuelNeeded = FuelAmount - (distance * FuelConsumptionPerKm);

            if (fuelNeeded < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }
            else
            {
                FuelAmount = fuelNeeded;
                TravelledDistance += distance;
            }
        }
    }
}
