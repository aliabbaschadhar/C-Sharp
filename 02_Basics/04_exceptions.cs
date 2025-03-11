using System;

namespace CSharpBasics
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            //Exceptions = errrors that occur during execution
            // try = try some code that is considered "dangerous"
            // catch = catch and handles exceptions when they occur
            // finally = always run this code even if there is an exception or not an exception

            double x;
            double y;
            double result = 0;

            try
            {

                Console.WriteLine("Enter first number: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero.Are you fan of BAPA-G ?");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}