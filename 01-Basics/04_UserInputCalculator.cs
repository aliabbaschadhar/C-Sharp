using System;

namespace CSharpBasics
{
    class UserInputCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");

            // Get first number
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            // IMPORTANT: Console.ReadLine() always returns a string, so conversion is necessary
            // for numerical operations

            // IMPORTANT: Convert.ToDouble will throw FormatException if input isn't a valid number
            // and OverflowException if the number is too large for a double
            double num1 = Convert.ToDouble(input1);

            // Get second number
            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            double num2 = Convert.ToDouble(input2);

            // Perform calculations
            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;

            // IMPORTANT: Division by zero causes runtime exception in C#
            // Always check for zero before dividing
            double quotient = 0;
            if (num2 != 0)
            {
                quotient = num1 / num2;
            }

            // Display results
            Console.WriteLine("\nResults:");
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {difference}");
            Console.WriteLine($"{num1} * {num2} = {product}");

            // IMPORTANT: String interpolation ($ prefix) allows embedding variables in strings
            // Much cleaner than string concatenation
            if (num2 != 0)
            {
                Console.WriteLine($"{num1} / {num2} = {quotient}");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = Cannot divide by zero");
            }

            // Area of a circle
            Console.WriteLine("\nCalculate Area of a Circle");
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // IMPORTANT: Math.PI provides a precise value of π
            double area = Math.PI * radius * radius;

            // IMPORTANT: The :F2 format specifier limits output to 2 decimal places
            // There are many format specifiers: C (currency), P (percentage), etc.
            Console.WriteLine($"Area of circle with radius {radius} is {area:F2}");

            // IMPORTANT: For more precise circle area calculation, use radius squared
            // Method 1: Using Math.Pow (exponentiation)
            double areaPow = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area using Math.Pow: {areaPow:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
