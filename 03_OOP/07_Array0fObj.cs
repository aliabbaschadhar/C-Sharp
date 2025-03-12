using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of objects
            Car[] garage = new Car[3];

            // Create 3 Car objects
            Car car1 = new Car("Corvette");
            Car car2 = new Car("Mustang");
            Car car3 = new Car("Challenger");

            // Assign the Car objects to the array
            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            // Console.WriteLine(garage[0].model);

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.WriteLine("\n--- Objects as Arguments Example ---");
            // Passing object as an argument
            DisplayCar(car1);

            // Passing multiple objects as arguments
            CompareModels(car1, car2);
        }

        static void DisplayCar(Car car)
        {
            Console.WriteLine($"This car is a {car.model}");
        }

        static void CompareModels(Car car1, Car car2)
        {
            Console.WriteLine($"Comparing {car1.model} with {car2.model}");
            if (car1.model.Length > car2.model.Length)
            {
                Console.WriteLine($"{car1.model} has a longer name than {car2.model}");
            }
            else if (car1.model.Length < car2.model.Length)
            {
                Console.WriteLine($"{car2.model} has a longer name than {car1.model}");
            }
            else
            {
                Console.WriteLine("Both car models have names of the same length");
            }
        }
    }

    class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
}