using System;
using System.Collections.Generic;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            var myCar = new Car();

            // Set values in the properties for the object
            myCar.Make = "Subaru";
            myCar.Model = "Crosstrek";
            myCar.Year = 2019;

            // creating another car, assigning 
            var suv = new Car()
            {
                Make = "GMC",
                Model = "Yukon XL",
                Year = 2001
            };

            // creating another car object using other constructor
            var eCar = new Car("Tesla", "Model 3", 2020);

            // Print the values of each property to the Console
            Console.WriteLine($"First vehicle is {myCar.Year} {myCar.Make} {myCar.Model}.");
            Console.WriteLine($"Second vehicle is {suv.Year} {suv.Make} {suv.Model}.");
            Console.WriteLine($"Third vehicle is {eCar.Year} {eCar.Make} {eCar.Model}.");
            Console.WriteLine();

            // creating a list of cars
            var carList = new List<Car>();
            carList.Add(myCar);
            carList.Add(suv);
            carList.Add(eCar);

            // Print for the carList:
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }

        }
    }
}
