using System;

namespace CSharpBasics
{
    class StringInterpolation
    {
        static void Main(string[] args)
        {
            int age = 20;
            string firstName = "Ali Abbas";
            string lastName = "Chadhar";

            Console.WriteLine($"My name is {firstName} {lastName} and I am {age} years old"); // My name is Ali Abbas and I am 20 years old
            Console.WriteLine("My name is {0} {1} and I am {2} years old", firstName, lastName, age); // My name is Ali Abbas and I am 20 years old
            Console.WriteLine($"Your age is {age,-30} and Bapa Stunning!"); // Your age is 20                             and Bapa Stunning!
            Console.WriteLine($"Your age is {age,30} and Bapa Stunning!");// Your age is                                20 and Bapa Stunning!

        }
    }
}