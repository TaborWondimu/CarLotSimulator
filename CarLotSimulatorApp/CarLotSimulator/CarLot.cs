using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   public class CarLot
    {
        // create a default constructor
        public CarLot()
        {
           
        }
        // Add a property
        public string ListOfCars {get;set;} // this will have the make and model
        public decimal PriceOfCars {get; set;}
        public int YearOfCars { get; set;}
        public bool IsAvailable {get; set;}

        public static int numberOfCars { get; set; }


    }
}
