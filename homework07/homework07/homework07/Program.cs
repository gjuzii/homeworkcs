using homework07.Models.Classes;
using homework07.Models.Enums;
using System;

namespace homework07
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;

            ElectricCar electricCar = new ElectricCar(id, "mazda", "navajo", 5, 150, Consumption.High, 100, 30);

            Console.WriteLine(electricCar.PrintInfo());
            electricCar.Drive(1200);
            electricCar.Recharge(85);

            Console.WriteLine("-----------------------------------------------");

            FuelCar fuelCar = new FuelCar(id, "porsche", "panamera", 2, 220, Consumption.Economic, EngineType.Diesel, 100, 30);
            Console.WriteLine(fuelCar.PrintInfo());
            fuelCar.Drive(1680);
            fuelCar.Refuel(62);

        }
    }
}
