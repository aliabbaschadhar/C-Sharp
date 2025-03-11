using System;

namespace CSharpBasics
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Basic Data Types\n");

            // Integer types
            int integerNumber = 10;
            // IMPORTANT: int uses 32 bits and ranges from -2,147,483,648 to 2,147,483,647
            Console.WriteLine("Integer: " + integerNumber);

            // Long type (for larger integers)
            long largeNumber = 9223372036854775807;
            // IMPORTANT: long uses 64 bits, suitable for very large numbers that exceed int capacity
            Console.WriteLine("Long: " + largeNumber);

            // Floating point types
            float floatNumber = 3.14f;
            // IMPORTANT: Note the 'f' suffix - without it, C# treats the literal as double by default
            double doubleNumber = 3.14159265359;
            // IMPORTANT: double has higher precision than float (15-16 digits vs 6-7) but uses more memory
            Console.WriteLine("Float: " + floatNumber);
            Console.WriteLine("Double: " + doubleNumber);

            // Decimal (precise for financial calculations)
            decimal moneyAmount = 1234.56m;
            // IMPORTANT: decimal type has 28-29 significant digits and is ideal for financial
            // calculations where rounding errors could be problematic
            Console.WriteLine("Decimal: " + moneyAmount);

            // Character type
            char letter = 'A';
            // IMPORTANT: char uses single quotes, while strings use double quotes
            Console.WriteLine("Character: " + letter);

            // Boolean type
            bool isTrue = true;
            // IMPORTANT: Unlike some languages, C# requires boolean values to be exactly 'true' or 'false'
            // (not 1 or 0, or other truthy/falsy values)
            Console.WriteLine("Boolean: " + isTrue);

            // String type
            string text = "Hello, C#!";
            // IMPORTANT: Strings in C# are immutable - once created, they cannot be changed
            Console.WriteLine("String: " + text);

            // Type conversion
            Console.WriteLine("\nType Conversion Example:");
            int x = 10;
            double y = x;  // Implicit conversion
            // IMPORTANT: Implicit conversions are allowed when no information is lost
            // (like int to double), but not when precision might be lost
            Console.WriteLine("Implicit conversion int to double: " + y);

            double z = 13.7;
            int w = (int)z;  // Explicit conversion
            // IMPORTANT: This is called casting - it can lead to data loss (the .7 is truncated, not rounded)
            Console.WriteLine("Explicit conversion double to int: " + w);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
