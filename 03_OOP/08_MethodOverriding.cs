using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method overriding = provides a new of a method inherited from a parent class
            //                    inherited method must be abstract, virtual, or already overridden 
            //                    Used with ToString(), polymorphism.

            Dog dog = new Dog(5);
            Cat cat = new Cat(6);

            dog.displayAge();
            cat.displayAge();

            dog.Speak();
            cat.Speak();
        }
    }

    abstract class Animal
    {
        protected int age;
        abstract public void Speak();
        // { } // Becase abstract methods can't have body
        abstract public void displayAge();
    }
    class Dog : Animal
    {
        public Dog(int age)
        {
            this.age = age;
        }
        // To override a method we have to expelcitely write override  in C# 
        public override void Speak()
        {
            Console.WriteLine("The dog goes *br* ");
        }
        public override void displayAge()
        {
            Console.WriteLine($"The dog is {this.age} years old");
        }
    }

    class Cat : Animal
    {
        // Always make constructor public otherwise the object of class can't be created.
        public Cat(int age)
        {
            this.age = age;
        }
        public override void Speak()
        {
            Console.WriteLine("The cat goes *br*");
        }

        public override void displayAge()
        {
            Console.WriteLine($"The cat is {this.age} years old");
        }
    }
}