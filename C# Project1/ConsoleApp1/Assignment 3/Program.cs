// written by Mamoutou Kane
// Date: 02/02/2025

using System;

class KingdomPointsCalculator
{
    static void Main()
    {
        // Ask the user for the number of provinces
        Console.WriteLine("Enter the number of provinces:");
        int provinces = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Ask the user for the number of duchies
        Console.WriteLine("Enter the number of duchies:");
        int duchies = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Ask the user for the number of estates
        Console.WriteLine("Enter the number of estates:");
        int estates = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Calculate the total points
        int totalPoints = (provinces * 6) + (duchies * 3) + (estates * 1);

        // Display the total points
        Console.WriteLine($"The total points for your kingdom are: {totalPoints}");
    }
}