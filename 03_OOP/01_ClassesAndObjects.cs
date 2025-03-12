using System;

namespace CSharpOOP
{
    // A class is a blueprint for creating objects
    // It defines properties (data) and methods (behavior)
    class Person
    {
        // Fields - variables that belong to the class
        // Usually private to protect the data
        private string name;
        private int age;

        // Properties - provide a flexible way to read/write field values
        // They encapsulate fields and can include validation logic
        public string Name
        {
            get { return name; } // Getter returns the field value
            set { name = value; } // Setter assigns a value to the field
        }

        // Auto-implemented property - C# creates the backing field automatically
        public string Address { get; set; }

        // Property with validation
        public int Age
        {
            get { return age; }
            set
            {
                // Validation logic
                if (value >= 0 && value <= 120)
                    age = value;
                else
                    Console.WriteLine("Invalid age value!");
            }
        }

        // Method - defines behavior
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
        }

        // Method with parameters and return value
        public string GetLifeStage()
        {
            if (age < 13) return "Child";
            else if (age < 20) return "Teenager";
            else if (age < 65) return "Adult";
            else return "Senior";
        }
    }

    class ClassesAndObjects
    {
        static void Main(string[] args)
        {
            // Creating an object (instance) of the Person class
            Person person1 = new Person();

            // Setting property values
            person1.Name = "John Doe";
            person1.Age = 30;
            person1.Address = "123 Main St";

            // Calling methods
            person1.Introduce();

            // Creating another object of the same class
            Person person2 = new Person();
            person2.Name = "Jane Smith";
            person2.Age = 25;
            person2.Address = "456 Oak Ave";

            person2.Introduce();
            Console.WriteLine($"{person2.Name} is a {person2.GetLifeStage()}.");

            // Testing validation
            Person person3 = new Person();
            person3.Age = 150; // This will trigger our validation logic

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
