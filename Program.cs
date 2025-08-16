using System;
namespace SecureCalculator;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Math Calculator ===");
        Console.WriteLine("1. Area & Perimeter of Rectangle");
        Console.WriteLine("2. Area & Circumference of Circle");
        Console.WriteLine("3. Solve Equation ax + b = 0");
        Console.Write("Choose an option (1-3): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                RectangleCalculation();
                break;
            case "2":
                CircleCalculation();
                break;
            case "3":
                EquationSolver();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    static void RectangleCalculation()
    {
        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        double perimeter = 2 * (length + width);

        Console.WriteLine($"Area = {area}");
        Console.WriteLine($"Perimeter = {perimeter}");
    }

    static void CircleCalculation()
    {
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        double circumference = 2 * Math.PI * radius;

        Console.WriteLine($"Area = {area:F2}");
        Console.WriteLine($"Circumference = {circumference:F2}");
    }

    static void EquationSolver()
    {
        Console.WriteLine("Equation format: ax + b = 0");

        Console.Write("Enter value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("No solution (a cannot be 0).");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Solution: x = {x}");
        }
    }
}

