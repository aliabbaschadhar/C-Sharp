using System;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enums = special "class" that contains a set of named integer constants.
            // Use enums when you have values that you know will not change,
            // To get the integer value from an item from enum, you must explicitly convert to an int 
            // name = integer

            Console.WriteLine($"{Planets.Pluto} is a palent no# {(int)Planets.Pluto}"); // Mercury is a palent no# 8

            string nameOfPlanet = PlanetRadius.Saturn.ToString(); // Saturn

            Console.WriteLine(nameOfPlanet);

            int radiusOfPlanet = (int)PlanetRadius.Saturn; // 58232

            Console.WriteLine(radiusOfPlanet);

            double volumeOfPlanet = Volume(PlanetRadius.Saturn);
            Console.WriteLine(volumeOfPlanet); // 827129915150898
        }

        public static double Volume(PlanetRadius radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow((double)radius, 3); // to get an value from an item from enum you must convert it into interger or numeric datatype
        }

    }

    enum Planets
    {
        // Start from index zero
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }

    enum PlanetRadius
    {
        Mercury = 2440,
        Venus = 6052,
        Earth = 6371,
        Mars = 3390,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}