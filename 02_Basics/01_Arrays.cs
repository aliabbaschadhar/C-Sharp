using System;

namespace MyFirstProgram
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Mustang", "Ferrari", "Rolls-Royace" };

            Console.WriteLine(string.Join(", ", cars));

            //Foreach loop
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int[] numbers = { 1, 21, 23, 13, 21, 123 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // To  create an array of fixed number of elements

            char[] vowels = new char[5];
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            foreach (char letter in vowels)
            {
                Console.Write(letter + "\t");
            }

            Console.WriteLine("\n");

            //For loop
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }

        }
    }
}