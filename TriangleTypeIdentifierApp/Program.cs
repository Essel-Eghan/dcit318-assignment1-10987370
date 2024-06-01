using System;

namespace TriangleTypeIdentifierApp
{
    public class TriangleTypeIdentifier
    {
        public static string IdentifyTriangle(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Triangle Type Identier project");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            Console.WriteLine("Let's identify your type of triangle.");

            Console.Write("Enter the length of side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            string triangleType = TriangleTypeIdentifier.IdentifyTriangle(side1, side2, side3);
            Console.WriteLine($"The triangle is {triangleType}.");
        }
    }
}
