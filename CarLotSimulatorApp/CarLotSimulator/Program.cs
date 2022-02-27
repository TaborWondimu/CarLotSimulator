using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var carOne = new Car();
            //Set the properties for each of the cars
            // This is using the dot notation
            carOne.Year = 2018;
            carOne.Make = "Honda";
            carOne.Model = "Accord";
            carOne.IsDriveable = true;
            carOne.EngineNoise = "BRUM BRUM BRUM";
            carOne.HonkNoise = "BEEEPPPP";

            // This is using the object intializer syntax
            var carTwo = new Car() { Year = 2021, Make = "BMW", Model = "X6", EngineNoise = "BRUM", HonkNoise = "BEPP", IsDriveable = true };

            var carThree = new Car()
            {
                Year = 2020,
                Make = "Subaru",
                Model = "Sontana",
                EngineNoise = "DIMING",
                HonkNoise = "SKIDDD",
                IsDriveable = false,

            };
            // This is using the constructor to allow parameters
            var lastCar = new Car(2021, "Honda", "Civic", "HGHGHGH", "NLUP", true);
            Console.WriteLine($"Number of Cars is = {Car.numberOfCars}");

            //Call each of the methods for each car
          //  carOne.MakeEngineNoise(carOne.EngineNoise);
           // carTwo.MakeHonkNoise(carTwo.HonkNoise);

            // used this to make sure my methods are working

            Console.WriteLine("------------------");


            //*************BONUS*************//

            // DONE- Set the properties utilizing the 3 different ways we learned about, one way for each car


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var carinLot1 = new CarLot();
            carinLot1.ListOfCars = "Honda Civic";
            carinLot1.PriceOfCars = 2568.65m;
            carinLot1.YearOfCars = 2020;
            carinLot1.IsAvailable = true;

            var carinLot2 = new CarLot(){ListOfCars = "BMW X6", PriceOfCars = 541212.23M, YearOfCars = 2021, IsAvailable = false};

            var hondaDealer = new List<CarLot>();
            hondaDealer.Add(carinLot1);
            hondaDealer.Add(carinLot2);

            foreach (var car in hondaDealer)
            {
                Console.WriteLine($"Car on Lot is {car.ListOfCars}, Price of car is ${car.PriceOfCars}, Year of Car is {car.YearOfCars}, Available : {car.IsAvailable}");
            }

            
         

             
        }
    }
}
