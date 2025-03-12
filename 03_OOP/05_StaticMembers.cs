using System;

namespace CSharpOOP
{
    // Class with static members and instance members
    class MathHelper
    {
        // Static field - shared by all instances of the class
        // Accessible via the class name: MathHelper.Pi
        public static double Pi = 3.14159;

        // Static property - shared by all instances of the class
        private static int calculationsPerformed = 0;
        public static int CalculationsPerformed
        {
            get { return calculationsPerformed; }
        }

        // Instance field - unique to each instance
        public string Description;

        // Static method - called on the class, not on an instance
        // Cannot access non-static members directly
        public static double CalculateCircleArea(double radius)
        {
            calculationsPerformed++;
            return Pi * radius * radius;
        }

        // Static method
        public static double CalculateRectangleArea(double width, double height)
        {
            calculationsPerformed++;
            return width * height;
        }

        // Instance method - called on an instance, can access both static and instance members
        public void DisplayPi()
        {
            Console.WriteLine($"{Description}: The value of Pi is {Pi}");
            Console.WriteLine($"Calculations performed so far: {calculationsPerformed}");
        }
    }

    // Static class - cannot be instantiated, can only contain static members
    // Useful for utility functions and constant values
    static class StringHelper
    {
        // Static property
        public static string DefaultGreeting { get; set; } = "Hello";

        // Static method
        public static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        // Static method with multiple parameters
        public static string Concatenate(params string[] strings)
        {
            return string.Join(" ", strings);
        }
    }

    // Class demonstrating static constructor
    class Logger
    {
        public static string LogFilePath { get; private set; }
        public static DateTime StartupTime { get; private set; }

        // Static constructor - called once before any static members are accessed
        // Has no access modifiers and no parameters
        static Logger()
        {
            LogFilePath = "app.log";
            StartupTime = DateTime.Now;
            Console.WriteLine("Logger initialized. Static constructor called.");
        }

        // Static method
        public static void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

    class StaticMembers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Static Members:\n");

            // Using static members without creating an instance
            Console.WriteLine("Using static members directly:");
            double circleArea = MathHelper.CalculateCircleArea(5);
            Console.WriteLine($"Circle area: {circleArea:F2}");

            double rectangleArea = MathHelper.CalculateRectangleArea(4, 6);
            Console.WriteLine($"Rectangle area: {rectangleArea:F2}");

            // Accessing static property
            Console.WriteLine($"Calculations performed: {MathHelper.CalculationsPerformed}");

            // Creating instances - each has its own instance members
            MathHelper helper1 = new MathHelper();
            helper1.Description = "Helper 1";
            helper1.DisplayPi();

            MathHelper helper2 = new MathHelper();
            helper2.Description = "Helper 2";
            helper2.DisplayPi();

            // Using static class
            Console.WriteLine("\nUsing static class:");
            string capitalized = StringHelper.Capitalize("hello world");
            Console.WriteLine($"Capitalized: {capitalized}");

            string concatenated = StringHelper.Concatenate("Hello", "from", "C#", "static", "methods!");
            Console.WriteLine($"Concatenated: {concatenated}");

            // Using class with static constructor
            Console.WriteLine("\nUsing class with static constructor:");
            // First access to Logger class will trigger its static constructor
            Console.WriteLine($"Log file path: {Logger.LogFilePath}");
            Console.WriteLine($"Startup time: {Logger.StartupTime}");
            Logger.Log("Application running");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
