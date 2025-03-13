using System;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface = Defines a "contract" that all the classes inheriting from it must follow
            //             An interface declares "what a class, should have!"
            //             An inheriting class defines "how it should do it"
            //             Benefit = security + multiple inheritance + "plug and play"

            // Interface vs abstract class
            // Interface = "what a class should have"
            // Abstract class = "how it should do it" // Can check for detail if you want to?

            Rabbit rabbit = new Rabbit();

            rabbit.Flee();

            Fish fish = new Fish();

            fish.Flee();
            fish.Hunt();

            HawK hawk = new HawK();
            hawk.Hunt();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredatro
        {
            void Hunt();
        }

        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabit is running away");
            }
        }

        class HawK : IPredatro
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food");
            }
        }

        class Fish : IPrey, IPredatro
        {
            public void Flee()
            {
                Console.WriteLine("The fish is swimming away");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for food");
            }
        }
    }
}