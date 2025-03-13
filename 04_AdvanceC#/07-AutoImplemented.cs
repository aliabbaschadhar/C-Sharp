using System;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {

            // Auto-implemented properties = Shortcuts when no addtional logic is required in the property, You don't have to define a field for a property
            // You on hve to write get; and/or set; inside the property
            // Auto-implemented properties are read-only by default
            // Can be used to access and modify private fields

            Car car = new Car("Corvette");

            Console.WriteLine(car.Model);

        }

        class Car
        {
            // string model;

            // public string Model
            // {
            //     get { return model; }
            //     set { model = value; }
            // }

            // So as we know that ther is no additional logic required in the property, we can use auto-implemented properties
            public string Model { get; set; }

            public Car(string model)
            {
                this.Model = model;
            }

        }
    }
}