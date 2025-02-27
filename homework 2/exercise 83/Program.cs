// written by Mamoutou Kane
// date: 02/06/2025
using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the cost per item
        const decimal COST_PER_ITEM = 19.99m;

        // Ask for the number of items
        Console.Write("Enter the number of items: ");
        int numberOfItems = int.Parse(Console.ReadLine());

        // Ask for the user's name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Calculate the total cost
        decimal totalCost = numberOfItems * COST_PER_ITEM;

        // Apply discount if the name matches
        if (userName.ToLower() == "your_name") // Replace "your_name" with your actual name
        {
            totalCost *= 0.5m; // Apply 50% discount
            Console.WriteLine("50% discount applied!");
        }

        // Display the result
        Console.WriteLine($"Total cost for {numberOfItems} items: ${totalCost:F2}");
    }
}

