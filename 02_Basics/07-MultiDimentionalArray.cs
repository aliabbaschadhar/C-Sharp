using System;

namespace CSharpBasics
{
    class MultiDimentionalArray
    {
        static void Main(string[] args)
        {
            // string[] ford = {"Mustang", "F-150", "F-250"};
            // string[] tesla = {"Model 3", "Model S", "Model X"};
            // string[] honda = {"Civic", "Accord", "CRV"};
            // string[] chevy = {"Corvette", "Camaro", "Equinox"};
            // string[] toyota = {"Camry", "Corolla", "Rav4"};

            // 2D array
            string[,] parkingLot = {
                {"Mustang", "F-150", "F-250"},
                {"Model 3", "Model S", "Model X"},
                {"Civic", "Accord", "CRV"},
                {"Corvette", "Camaro", "Equinox"},
                {"Camry", "Corolla", "Rav4"}
            };

            parkingLot[0, 2] = "lamborgini";

            foreach (string car in parkingLot)
            {
                Console.WriteLine(car);
            }

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
        }
    }
}
