using homework07.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework07.Models.Classes
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public  EngineType EngineType { get; set; }

        public Car(int id, string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType)
        {
            Id = new Random().Next(100, 500);
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
            EngineType = engineType;

        }

       
        public string PrintInfo()
        {
            return $"Car ID: {Id} Brand: {Brand} Car Model: {Model} Doors: {Doors} Top Speed: {TopSpeed} Consumption {Consumption} Engine Type: {EngineType}";

        }


    }
}
