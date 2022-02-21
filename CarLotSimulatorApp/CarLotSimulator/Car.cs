using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   public class Car
    {
        public Car()
        {
            // DEFAULT 
        }
        // A constructor that assigns property
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Make = make;
            Year = year;
            Model = model;
            EngineNoise = engineNoise;
            IsDriveable = isDrivable;
            HonkNoise = honkNoise;
        }
        public int Year { get; set;}

        public string Make { get; set;}

        public string Model { get; set;}

        public string EngineNoise { get; set;}

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
           Console.WriteLine(noise);
        }
        public void MakeHonkNoise(string honk)
        {
           Console.WriteLine(honk);
        }
    }
}
