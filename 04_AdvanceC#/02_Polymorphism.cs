using System;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism = Greek word that means to "have many forms"
            //                Objects can indentified by more than type
            //                Ex. A dog is also : Canine, Animal, Organism

            Car car = new Car();
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();

            // Car[] cars = { car, boat, bicycle }; // Causes error becuase we cannot store objects of different types in an array
            // car has difference type and boat has different type and bicycle has different 

            // So by using polymorphism we can see that they are all objects of type vehicle

            Vehicle[] vehicles = { car, boat, bicycle };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

        }
    }

    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }
}