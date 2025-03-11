using System;

namespace CSharpBasics
{
    class Ternary
    {
        static void Main(string[] args)
        {

            int age = 20;
            // If condition is true return this or else return this
            // In C# ternary operator returns something based on the condition
            string message = (age > 18) ? "You can vote" : "You cannot vote";
            Console.WriteLine(message);
        }
    }
}