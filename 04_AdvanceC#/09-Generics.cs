using System;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics = "Not specific to a particlar datatype"
            // add<T> to: classes, methods, fields, etc.
            // allows code reuseability for different datatypes

            int[] ints = { 1, 2, 3, 4, 5 };
            double[] doubles = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] strings = { "one", "two", "three", "four", "five" };

            // To display all those arrays we have to create three different functions for all of them.
            // displayInts(ints);
            // displayDoubles(doubles);

            // We can avoid this using generics.

            displayElements<int>(ints);
            displayElements<double>(doubles);
            displayElements<string>(strings);
        }

        // Generic Method

        public static void displayElements<Thing>(Thing[] things)
        {
            foreach (Thing item in things)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void displayInts(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
        }

        public static void displayDoubles(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write(item);
            }
        }
    }
}