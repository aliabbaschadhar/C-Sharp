using System;

namespace CSharpOOP
{
    // Abstract class - cannot be instantiated directly
    // Used as a base class for other classes
    abstract class Shape
    {
        // Regular property that derived classes will inherit
        public string Color { get; set; }

        // Constructor in an abstract class
        public Shape(string color)
        {
            Color = color;
        }

        // Abstract method - no implementation, must be overridden by derived classes
        // The 'abstract' keyword forces derived classes to implement this method
        public abstract double CalculateArea();

        // Abstract method without parameters
        public abstract void DisplayType();

        // Regular method with implementation that derived classes inherit
        public void DisplayColor()
        {
            Console.WriteLine($"This shape is {Color}");
        }

        // Virtual method - has default implementation but can be overridden
        public virtual string GetDetails()
        {
            return $"This is a shape with color: {Color}";
        }
    }

    // Concrete class derived from the abstract class
    // Must implement all abstract methods
    class Circle : Shape
    {
        // Circle-specific property
        public double Radius { get; set; }

        // Constructor that calls the base constructor
        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        // Implementation of the abstract method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Implementation of the abstract DisplayType method
        public override void DisplayType()
        {
            Console.WriteLine("I am a circle");
        }

        // Override of the virtual method
        public override string GetDetails()
        {
            return $"This is a {Color} circle with radius {Radius} and area {CalculateArea():F2}";
        }
    }

    // Another concrete class derived from the abstract class
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        // Implementation of the abstract method
        public override double CalculateArea()
        {
            return Width * Height;
        }

        // Implementation of the abstract DisplayType method
        public override void DisplayType()
        {
            Console.WriteLine("I am a rectangle");
        }

        // Override of the virtual method
        public override string GetDetails()
        {
            return $"This is a {Color} rectangle with width {Width}, height {Height} and area {CalculateArea():F2}";
        }
    }

    class AbstractClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Abstract Classes:\n");

            // Cannot create an instance of an abstract class
            // Shape shape = new Shape("Red"); // This would cause a compilation error

            // Create instances of concrete classes
            Circle circle = new Circle("Blue", 5.0);
            Rectangle rectangle = new Rectangle("Green", 4.0, 6.0);

            // Call methods on concrete instances
            Console.WriteLine("Working with Circle:");
            circle.DisplayType();
            circle.DisplayColor(); // Inherited method
            Console.WriteLine($"Area: {circle.CalculateArea():F2}");
            Console.WriteLine(circle.GetDetails());
            Console.WriteLine();

            Console.WriteLine("Working with Rectangle:");
            rectangle.DisplayType();
            rectangle.DisplayColor(); // Inherited method
            Console.WriteLine($"Area: {rectangle.CalculateArea():F2}");
            Console.WriteLine(rectangle.GetDetails());
            Console.WriteLine();

            // Polymorphism with abstract class
            Console.WriteLine("Demonstrating polymorphism with abstract classes:");
            Shape[] shapes = { circle, rectangle };

            foreach (Shape shape in shapes)
            {
                // The correct implementation is called based on the actual object type
                shape.DisplayType();
                Console.WriteLine($"Area: {shape.CalculateArea():F2}");
                Console.WriteLine(shape.GetDetails());
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
