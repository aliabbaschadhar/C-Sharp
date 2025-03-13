using System;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() is a method that returns a string representation of an object
            // So that it is suitable for display or logging

            Car car = new Car("Corvette", "Chevrolet", 2022, "Red");
            Car car1 = new Car("Mustang", "Ford", 2022, "Red");

            // Console.WriteLine(car.ToString()); // Before overriding ToString method it returns "CSharpAdvance.Car"

            Console.WriteLine(car1.ToString()); // Mustang Ford 2022 Red
            Console.WriteLine(car); // Corvette Chevrolet 2022 Red 
            // After overriding the ToString method automatically get invoked when we print the object like above

        }
    }

    class Car
    {
        string model;
        string make;
        int year;
        string color;

        public Car(string model, string make, int year, string color)
        {
            this.model = model;
            this.year = year;
            this.make = make;
            this.color = color;
        }

        public override string ToString()
        {
            return $"{model} {make} {year} {color}";
        }
    }
}