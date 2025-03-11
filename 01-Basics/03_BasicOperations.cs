using System;

namespace CSharpBasics
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Basic Arithmetic Operations\n");

            // Declaring variables
            int a = 10;
            int b = 5;

            // Addition
            int sum = a + b;
            Console.WriteLine($"Addition: {a} + {b} = {sum}");

            // Subtraction
            int difference = a - b;
            Console.WriteLine($"Subtraction: {a} - {b} = {difference}");

            // Multiplication
            int product = a * b;
            Console.WriteLine($"Multiplication: {a} * {b} = {product}");

            // Division
            int quotient = a / b;
            // IMPORTANT: Integer division truncates the result - it does not round!
            // When dividing two integers, the result will always be an integer
            Console.WriteLine($"Division: {a} / {b} = {quotient}");

            // IMPORTANT: To get decimal division results with integers, convert at least one operand to double
            double decimalQuotient = (double)a / b;
            Console.WriteLine($"Decimal division: {a} / {b} = {decimalQuotient}");

            // Modulus (remainder)
            int remainder = a % b;
            // IMPORTANT: Modulus gives remainder of division, useful for checking divisibility
            // (x % 2 == 0 tells us if x is even)
            Console.WriteLine($"Modulus: {a} % {b} = {remainder}");

            // Increment and decrement
            int c = 1;
            c++;
            // IMPORTANT: There's also prefix (++c) vs postfix (c++) increment:
            // In prefix, increment happens before the value is used
            // In postfix, increment happens after the value is used
            Console.WriteLine($"After increment: {c}");
            c--;
            Console.WriteLine($"After decrement: {c}");

            // Compound assignment operators
            int d = 10;
            d += 5;  // same as d = d + 5
            // IMPORTANT: Compound operators combine operation and assignment, reducing code verbosity
            Console.WriteLine($"After compound addition: {d}");

            d *= 2;  // same as d = d * 2
            Console.WriteLine($"After compound multiplication: {d}");

            // IMPORTANT: C# follows PEMDAS order of operations (Parentheses, Exponents,
            // Multiplication/Division, Addition/Subtraction)
            int result = 5 + 3 * 2;  // 11, not 16
            Console.WriteLine($"\nOrder of operations: 5 + 3 * 2 = {result}");
            int resultWithParentheses = (5 + 3) * 2;  // 16
            Console.WriteLine($"With parentheses: (5 + 3) * 2 = {resultWithParentheses}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
