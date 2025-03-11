using System;
using System.Linq; // Like header files in cpp.
// Linq is a namespace in .NET that provides classes and interfaces which support queries that use Language-Integrated Query (LINQ). LINQ allows you to write queries against collections of objects using a SQL-like syntax.

// In your code, you're using `prices.Sum()` which is a LINQ extension method that calculates the sum of a sequence of numeric values. The `using System.Linq;` statement at the top of your file is necessary to use LINQ methods like `Sum()`, `Where()`, `Select()`, etc.

namespace CSharpBasics
{
    class ParamsKeyword
    {
        static void Main(string[] args)
        {
            // params keyword: allows you to pass a variable number of arguments to a method
            // params keyword is used to indicate that the method can accept any number of arguments.
            // The parameter type must be of type single dimentional array

            double total = checkout(3.99, 5.75, 1.25, 4.99, 6.99);
            Console.WriteLine("Total: " + total);
        }

        // static checkout(double a , double b ){
        //     return a+b;
        // }
        // static checkout(double a , double b , double c){
        //     return a+b+c;
        // }

        // Instead of writing this over and over again, we can use params keyword

        static double checkout(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            // return total;

            //* Or we can do that in one line
            return prices.Sum();
        }
    }
}