using System;

namespace homework05
{
    class Program
    {
        static void Main(string[] args)
        {


            Car hyundai = new Car("Hyundai", 200);
            Car mazda = new Car("Mazda", 160);
            Car ferrari = new Car("Ferrari", 180);
            Car porsche = new Car("Porsche", 120);

            Driver bob = new Driver("Bob", 8);
            Driver greg = new Driver("Greg", 5);
            Driver jill = new Driver("Jill", 7);
            Driver anne = new Driver("Ane", 9);


            static  void RaceCars(Car firstCar, Car secondCar)
            {
                if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed())
                    Console.WriteLine($"Driver {firstCar.Driver.Name} wins by driving  {firstCar.Model} car.");
                else if (firstCar.CalculateSpeed() < secondCar.CalculateSpeed())
                {
                    Console.WriteLine($"Car no. 2 was faster.");
                    Console.WriteLine($"{secondCar.Model} won the Race, with speed {secondCar.Speed} km/h, and the driver was {secondCar.Driver.Name}");
                }
            }






            Console.WriteLine($"Choose a car with a number:\n1.{hyundai.Model}\n2.{mazda.Model}\n3.{ferrari.Model}\n4.{porsche.Model}");
            bool parsedInputCar = int.TryParse(Console.ReadLine(), out int firstCarInput);
            string firstCar = "";
            int firstCarSpeed = 0;

            if (parsedInputCar)
            {
                switch (firstCarInput)
                {
                    case 1:
                        firstCar = hyundai.Model;
                        firstCarSpeed = hyundai.Speed;
                        Console.WriteLine("You chose Hyundai");
                        break;
                    case 2:
                        firstCar = mazda.Model;
                        firstCarSpeed = mazda.Speed;
                        Console.WriteLine("You chose Mazda");
                        break;
                    case 3:
                        firstCar = ferrari.Model;
                        firstCarSpeed = ferrari.Speed;
                        Console.WriteLine("You chose Ferrari");
                        break;
                    case 4:
                        firstCar = porsche.Model;
                        firstCarSpeed = porsche.Speed;
                        Console.WriteLine("You chose Porsche");
                        break;

                };

                Console.WriteLine($"Choose a Driver for the car with a number:\n1.{bob.Name}\n2.{greg.Name}\n3.{jill.Name}\n4.{anne.Name}");
                bool parsedInputDriver = int.TryParse(Console.ReadLine(), out int firstDriverInput);
                string firstDriver = "";
                int firstDriverSkill = 0;

                if (parsedInputDriver)
                {
                    switch (firstDriverInput)
                    {
                        case 1:
                            firstDriver = bob.Name;
                            firstDriverSkill = bob.Skill;
                            break;
                        case 2:
                            firstDriver = greg.Name;
                            firstDriverSkill = greg.Skill;
                            break;
                        case 3:
                            firstDriver = jill.Name;
                            firstDriverSkill = jill.Skill;
                            break;
                        case 4:
                            firstDriver = anne.Name;
                            firstDriverSkill = anne.Skill;
                            break;
                    };

                    Car carOne = new Car(firstCar, firstCarSpeed);
                    Driver driverOne = new Driver(firstDriver, firstDriverSkill);
                    carOne.Driver = driverOne;

                    Console.WriteLine($"Chose a second car with a number: :\n1.{hyundai.Model}\n2.{mazda.Model}\n3.{ferrari.Model}\n4.{porsche.Model}");
                    bool parsedInputSecondCar = int.TryParse(Console.ReadLine(), result: out int secondCarInput);
                    string secondCar = "";
                    int secondCarSpeed = 0;

                    if (parsedInputSecondCar)
                    {
                        switch (secondCarInput)
                        {
                            case 1:
                                secondCar = hyundai.Model;
                                secondCarSpeed = hyundai.Speed;
                                break;
                            case 2:
                                secondCar = mazda.Model;
                                secondCarSpeed = mazda.Speed;
                                break;
                            case 3:
                                secondCar = ferrari.Model;
                                secondCarSpeed = ferrari.Speed;
                                break;
                            case 4:
                                secondCar = porsche.Model;
                                secondCarSpeed = porsche.Speed;
                                break;
                        }

                    }

                    Console.WriteLine($"Choose a  second driver for the second car with a number:\n1.{bob.Name}\n2.{greg.Name}\n3.{jill.Name}\n4.{anne.Name}");
                    bool parsedInputSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriverInput);
                    string secondDriver = "";
                    int secondDriverSkill = 0;
                    if (parsedInputSecondDriver)
                    {
                        switch (secondDriverInput)
                        {
                            case 1:
                                secondDriver = bob.Name;
                                secondDriverSkill = bob.Skill;
                                break;
                            case 2:
                                secondDriver = greg.Name;
                                secondDriverSkill = greg.Skill;
                                break;
                            case 3:
                                secondDriver = jill.Name;
                                secondDriverSkill = jill.Skill;
                                break;
                            case 4:
                                secondDriver = anne.Name;
                                secondDriverSkill = anne.Skill;
                                break;

                        };

                    }

                    Car carTwo = new Car(secondCar, secondCarSpeed);
                    Driver driverTwo = new Driver(secondDriver, secondDriverSkill);
                    carTwo.Driver = driverTwo;



                    RaceCars(carOne, carTwo);



                }

            }
        }
    }
}

