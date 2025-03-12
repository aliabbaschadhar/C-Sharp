using System;

namespace CSharpOOP
{
    class Student
    {
        // Fields
        public string Name;
        public int Age;
        public string Major;
        public double GPA;

        // Default constructor (no parameters)
        // Called when you create an object with no arguments: new Student()
        public Student()
        {
            // Initialize with default values
            Name = "Unknown";
            Age = 18;
            Major = "Undeclared";
            GPA = 0.0;
            Console.WriteLine("Default constructor called");
        }

        // Parameterized constructor with two parameters
        // Constructor overloading - multiple constructors with different parameters
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Major = "Undeclared";
            GPA = 0.0;
            Console.WriteLine("Two-parameter constructor called");
        }

        // Fully parameterized constructor
        public Student(string name, int age, string major, double gpa)
        {
            Name = name;
            Age = age;
            Major = major;
            GPA = gpa;
            Console.WriteLine("Four-parameter constructor called");
        }

        // Constructor chaining - calling one constructor from another using 'this'
        // This reduces code duplication
        public Student(string name, string major) : this(name, 18, major, 0.0)
        {
            Console.WriteLine("Two-parameter constructor with chaining called");
        }

        // Display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Major: {Major}, GPA: {GPA:F2}");
        }
    }

    class Constructors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating students with different constructors:\n");

            // Using default constructor
            Student student1 = new Student();
            student1.DisplayInfo();
            Console.WriteLine();

            // Using two-parameter constructor
            Student student2 = new Student("Alex Smith", 20);
            student2.DisplayInfo();
            Console.WriteLine();

            // Using fully parameterized constructor
            Student student3 = new Student("Maria Garcia", 22, "Computer Science", 3.85);
            student3.DisplayInfo();
            Console.WriteLine();

            // Using constructor with chaining
            Student student4 = new Student("Jamal Wilson", "Physics");
            student4.DisplayInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
