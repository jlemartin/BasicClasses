using System;
namespace BasicClasses
{
    public class Car
    {
        // Constructor
        public Car()
        {
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Properties
        // Create a Make property of type string that is public
        public string Make { get; set; }

        // Create a Model property of type string that is public
        public string Model { get; set; }

        // Create a Year property of type int that is public
        public int Year { get; set; }


    }
}
