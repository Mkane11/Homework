// written by Mamoutou Kane
// date: 02/02/2025

using System;

class TriangleAreaCalculator
{
    static void Main()
    {
        // Prompt user for base and height
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area
        double area = (baseLength * height) / 2;

        // Display the result
        Console.WriteLine($"The area of the triangle is: {area}");
    }
}