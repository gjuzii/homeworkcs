using homework07.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework07.Models.Classes
{
    class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }

        public FuelCar(int id, string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType, int fuleCapacity, int currentFuel)
            : base(id, brand, model, doors, topSpeed, consumption, engineType)
        {

            FuelCapacity = fuleCapacity;
            CurrentFuel = currentFuel;
        }

        public void Drive(int distance)
        {
            int usedFuel = 0;

            if (Consumption == Consumption.Economic)
            {
                usedFuel = distance * 1 / 10;
            }
            if (Consumption == Consumption.Medium)
            {
                usedFuel = distance * 2 / 10;
            }
            if (Consumption == Consumption.High)
            {
                usedFuel = distance * 3 / 10;
            }

            int fuel = (usedFuel * 100) / FuelCapacity;

            if (fuel  >= 100)
            {
                Console.WriteLine($"Sorry you have used all the capasity from this car.");

            }
            else if (fuel < 100)
            {
                Console.WriteLine($"You have left {CurrentFuel}");
            }

        }



        public void Refuel(int fuel)
        {
            int gasTank = FuelCapacity - CurrentFuel;

            if (fuel > gasTank)
            {
                Console.WriteLine($"The maximum of the tank is reached. Can't refuel more than {gasTank} liters.");
            }
            else
            {
                Console.WriteLine($"Your tank is now refueled with  {fuel} liters.");
            }

        }
    }

}

