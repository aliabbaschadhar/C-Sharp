using System;

namespace CSharpBasics
{
    class Methods
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result = 0;

            Console.WriteLine("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            result = multiply(a, b);

            Console.WriteLine("Result: " + result);

            // Method overloading
            double resultOverloaded = multiply(a, b, 2);
            Console.WriteLine("Result overloaded: " + resultOverloaded);
        }

        static double multiply(double a, double b)
        {
            return a * b;
        }

        // Method overloading

        static double multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}