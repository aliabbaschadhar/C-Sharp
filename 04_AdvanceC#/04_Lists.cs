using System;
using System.Collections.Generic;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists = Data structure that represents a list of objects that can be accessed by index.
            // Similar to array, but can grow and shrink in size dynamically
            // using System.Collections.Generic;

            string[] foods = new string[3];
            // foods[3] = "pizza"; // Will give indexoutofbounds error

            List<string> food = new List<string>();
            food.Add("pasta");
            food.Add("pizza");
            food.Add("pasta");
            food.Add("sushi");

            food.Insert(1, "salad");

            Console.WriteLine($"My favorite food is {food[1]}");

            Console.WriteLine(food.Count); // Length of list

            Console.WriteLine(food.IndexOf("pasta"));

            Console.WriteLine(food.LastIndexOf("pasta")); // Tells the last index of given key

            Console.WriteLine(food.Contains("sushi"));

            // food.Sort(); // Sorts the list alphabatically

            food.Reverse();
            // food.Clear(); // Clears the list

            foreach (string foodItem in food)
            {
                Console.WriteLine($"Eating {foodItem}");
            }

            food.Remove("pasta");
            Console.WriteLine("After removing pasta");
            foreach (string foodItem in food)
            {
                Console.WriteLine($"Eating {foodItem}");
            }
        }
    }
}