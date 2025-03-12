using System;

namespace CSharpOOP
{
    // Base class (parent class)
    class Animal
    {
        // Protected members are accessible within the class and by derived classes
        protected string name;
        protected int age;

        // Constructor
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Virtual method - can be overridden by derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

        // Regular method
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping...");
        }

        // Method that will be overridden
        public virtual string GetDescription()
        {
            return $"{name} is {age} years old";
        }
    }

    // Derived class (child class) - inherits from Animal
    // Syntax: class ChildClass : ParentClass
    class Dog : Animal
    {
        public string Breed { get; set; }

        // Constructor that calls the base constructor
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine($"{name} barks: Woof! Woof!");
        }

        // New method specific to Dog
        public void Fetch()
        {
            Console.WriteLine($"{name} is fetching the ball!");
        }

        // Override the GetDescription method
        public override string GetDescription()
        {
            // Use base.GetDescription() to reuse parent's implementation
            return $"{base.GetDescription()} and is a {Breed} dog";
        }
    }

    // Another derived class from Animal
    class Cat : Animal
    {
        public bool IsIndoor { get; set; }

        // Constructor calling the base constructor
        public Cat(string name, int age, bool isIndoor) : base(name, age)
        {
            IsIndoor = isIndoor;
        }

        // Override the virtual method
        public override void MakeSound()
        {
            Console.WriteLine($"{name} meows: Meow! Meow!");
        }

        // New method specific to Cat
        public void Climb()
        {
            Console.WriteLine($"{name} is climbing the tree!");
        }

        public override string GetDescription()
        {
            string catType = IsIndoor ? "indoor" : "outdoor";
            return $"{base.GetDescription()} and is an {catType} cat";
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Inheritance:\n");

            // Creating objects of derived classes
            Dog dog = new Dog("Buddy", 3, "Golden Retriever");
            Cat cat = new Cat("Whiskers", 5, true);

            // Call methods from base class
            Console.WriteLine("Calling methods from base class:");
            dog.Sleep(); // Inherited from Animal
            cat.Sleep(); // Inherited from Animal

            // Call overridden methods
            Console.WriteLine("\nCalling overridden methods:");
            dog.MakeSound(); // Overridden in Dog class
            cat.MakeSound(); // Overridden in Cat class

            // Call methods specific to derived classes
            Console.WriteLine("\nCalling class-specific methods:");
            dog.Fetch(); // Defined in Dog class
            cat.Climb(); // Defined in Cat class

            // Polymorphism - treating derived classes as base class
            Console.WriteLine("\nDemonstrating polymorphism:");
            Animal[] animals = { dog, cat };

            foreach (Animal animal in animals)
            {
                // The correct overridden method is called based on the actual object type
                animal.MakeSound();
                Console.WriteLine(animal.GetDescription());
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
