using homework07.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework07.Models.Classes
{
    class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }

        public ElectricCar(int id, string brand, string model, int doors, int topSpeed, Consumption consumption, int batteryCapacity, int batteryUsage)
            : base (id, brand, model, doors, topSpeed, consumption, EngineType.Electric)
        {
            EngineType = EngineType.Electric;
            BatteryCapacity = 100;
        }

        public void Drive(int distance)
        {
            int usedBattery = 0;



            if (Consumption == Consumption.Economic)
            {
                usedBattery = distance * 1 / 10;
            }
            if (Consumption == Consumption.Medium)
            {
                usedBattery = distance * 2 / 10;
            }
            if (Consumption == Consumption.High)
            {
                usedBattery = distance * 3 / 10;
            }

            int battery = (usedBattery * 100) / BatteryCapacity;
            if (battery >= 100)
            {
                Console.WriteLine($"Sorry you have used all the capasity from this car.");

            }
            else if (battery < 100)
            {
                Console.WriteLine($"You have left {BatteryUsage - BatteryCapacity}%");
            }
        }

        public void Recharge (int minutes) 

        {
            int recharge = minutes / 10;
            if (minutes == 10 * 100)
            {
                Console.WriteLine($"Can't charge longer than {minutes} minutes.");
            }
            else
            {
                BatteryCapacity += recharge;
                Console.WriteLine($"Your battery have been charged {recharge} %.");
            }
            //int currentBatteryCapacity = BatteryCapacity - BatteryUsage;
            //int rechargeBattery =  currentBatteryCapacity * 10;
            //int batteryRecharged = ;

            //if (batteryRecharged > rechargeBattery)
            //{
            //    Console.WriteLine($"Can't charge longer than {rechargeBattery * 10} minutes.");
            //}
            //else
            //{
            //    Console.WriteLine($"Your battery have been charged {batteryRecharged} %.");
            //}


        }

    }
}
