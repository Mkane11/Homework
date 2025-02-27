// Written by Mamoutou Kane
// Date: 02/02/2025
using System;

class DefenseOfConsolas
{
    static void Main()
    {
        // Change the console title
        Console.Title = "Defense of Consolas";

        // Step 1: Ask the user for the target row and column
        Console.Write("Target Row? ");
        int targetRow = Convert.ToInt32(Console.ReadLine());

        Console.Write("Target Column? ");
        int targetColumn = Convert.ToInt32(Console.ReadLine());

        // Step 2: Compute deployment locations
        int leftColumn = targetColumn - 1;
        int rightColumn = targetColumn + 1;
        int topRow = targetRow - 1;
        int bottomRow = targetRow + 1;

        // Step 3: Display deployment instructions in a different color
        Console.ForegroundColor = ConsoleColor.Green; // Change text color to green
        Console.WriteLine("\nDeploy to:");
        Console.WriteLine($"({targetRow}, {leftColumn})");
        Console.WriteLine($"({topRow}, {targetColumn})");
        Console.WriteLine($"({targetRow}, {rightColumn})");
        Console.WriteLine($"({bottomRow}, {targetColumn})");

        // Reset the console color back to default
        Console.ResetColor();

        // Step 4: Play a beep sound to indicate the results are ready
        Console.Beep();
    }
}
