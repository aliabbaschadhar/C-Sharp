using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    // Abstract base class for different employee types
    abstract class Employee
    {
        // Properties
        public string Name { get; set; }
        public int ID { get; set; }
        protected double baseSalary;

        // Static property tracks total number of employees
        private static int totalEmployees = 0;
        public static int TotalEmployees => totalEmployees;

        // Static constructor
        static Employee()
        {
            Console.WriteLine("Employee tracking system initialized");
        }

        // Constructors - overloaded
        public Employee()
        {
            Name = "New Employee";
            baseSalary = 30000;
            ID = GenerateEmployeeID();
            totalEmployees++;
        }

        public Employee(string name, double salary)
        {
            Name = name;
            baseSalary = salary;
            ID = GenerateEmployeeID();
            totalEmployees++;
        }

        // Static method to generate employee ID
        private static int lastID = 1000;
        private static int GenerateEmployeeID()
        {
            return ++lastID;
        }

        // Virtual method that can be overridden
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}");
        }

        // Abstract method that must be implemented by derived classes
        public abstract double CalculateMonthlySalary();

        // Regular method
        public void GiveRaise(double percentage)
        {
            if (percentage > 0)
            {
                baseSalary += baseSalary * (percentage / 100);
                Console.WriteLine($"{Name} received a {percentage}% raise");
            }
        }
    }

    // Manager class inherits from Employee
    class Manager : Employee
    {
        public double Bonus { get; set; }
        public List<Employee> Team { get; } = new List<Employee>();

        // Constructor chaining
        public Manager() : base()
        {
            Bonus = 5000;
        }

        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }

        // Override the abstract method
        public override double CalculateMonthlySalary()
        {
            return (baseSalary / 12) + (Bonus / 12);
        }

        // Override the virtual method and extend its functionality
        public override void DisplayInfo()
        {
            // Call the base class implementation
            base.DisplayInfo();
            Console.WriteLine($"Position: Manager, Team Size: {Team.Count}, Annual Salary: ${baseSalary:F2}, Annual Bonus: ${Bonus:F2}");
        }

        // Method specific to Manager
        public void AddTeamMember(Employee employee)
        {
            Team.Add(employee);
            Console.WriteLine($"{employee.Name} added to {Name}'s team");
        }
    }

    // Developer class inherits from Employee
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public bool HasStockOptions { get; set; }

        public Developer(string name, double salary, string language, bool hasStockOptions)
            : base(name, salary)
        {
            ProgrammingLanguage = language;
            HasStockOptions = hasStockOptions;
        }

        // Override the abstract method
        public override double CalculateMonthlySalary()
        {
            double monthlySalary = baseSalary / 12;
            if (HasStockOptions)
            {
                monthlySalary += 500; // Additional compensation for stock options
            }
            return monthlySalary;
        }

        // Override the virtual method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Position: Developer, Language: {ProgrammingLanguage}, " +
                            $"Annual Salary: ${baseSalary:F2}, Has Stock Options: {HasStockOptions}");
        }

        // Method specific to Developer
        public void CodeReview()
        {
            Console.WriteLine($"{Name} is reviewing code using {ProgrammingLanguage} expertise.");
        }
    }

    // Static utility class for the company
    static class CompanyUtility
    {
        public static string CompanyName { get; set; } = "Tech Innovations Inc.";

        public static void DisplayCompanyInfo()
        {
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Total Employees: {Employee.TotalEmployees}");
        }

        public static double CalculateAverageSalary(List<Employee> employees)
        {
            if (employees.Count == 0) return 0;

            double total = 0;
            foreach (var employee in employees)
            {
                total += employee.CalculateMonthlySalary();
            }

            return total / employees.Count;
        }
    }

    class ComprehensiveExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comprehensive OOP Example - Employee Management System\n");

            // Create a list to store all employees
            List<Employee> allEmployees = new List<Employee>();

            // Create manager instances
            Manager techManager = new Manager("Sarah Johnson", 85000, 15000);
            Manager productManager = new Manager("David Lee", 90000, 18000);

            // Create developer instances
            Developer dev1 = new Developer("Mike Chen", 75000, "C#", true);
            Developer dev2 = new Developer("Lisa Wong", 72000, "JavaScript", false);
            Developer dev3 = new Developer("Carlos Rodriguez", 78000, "Python", true);

            // Build team structure
            techManager.AddTeamMember(dev1);
            techManager.AddTeamMember(dev2);
            productManager.AddTeamMember(dev3);

            // Add all employees to the list
            allEmployees.Add(techManager);
            allEmployees.Add(productManager);
            allEmployees.Add(dev1);
            allEmployees.Add(dev2);
            allEmployees.Add(dev3);

            // Display company information using static utility class
            Console.WriteLine("\nCompany Overview:");
            CompanyUtility.DisplayCompanyInfo();

            // Display all employees with polymorphism
            Console.WriteLine("\nEmployee Details:");
            foreach (var employee in allEmployees)
            {
                // Polymorphic call - the correct version runs based on the actual object type
                employee.DisplayInfo();
                Console.WriteLine($"Monthly Salary: ${employee.CalculateMonthlySalary():F2}");
                Console.WriteLine();
            }

            // Give raises
            dev1.GiveRaise(10);
            techManager.GiveRaise(7);

            // Calculate and display average monthly salary
            double avgSalary = CompanyUtility.CalculateAverageSalary(allEmployees);
            Console.WriteLine($"\nAverage Monthly Salary: ${avgSalary:F2}");

            // Specialized method calls
            Console.WriteLine("\nSpecialized Activities:");
            dev1.CodeReview();
            Console.WriteLine($"{techManager.Name} manages a team of {techManager.Team.Count} employees");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
