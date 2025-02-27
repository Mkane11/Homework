// written by Mamoutou Kane
// Date: 02/02/2025
using System;

class ChocolateEggsDivision
{
    static void Main()
    {
        // Step 1: Prompt the user to enter the total number of chocolate eggs
        Console.Write("Enter the total number of chocolate eggs: ");
        int totalEggs = Convert.ToInt32(Console.ReadLine()); // Read and convert input to an integer

        // Step 2: Calculate how many eggs each sister gets and how many are left for the duckbear
        int eggsPerSister = totalEggs / 4; // Integer division
        int eggsForDuckbear = totalEggs % 4; // Remainder

        // Step 3: Display the results
        Console.WriteLine($"\nEach sister gets: {eggsPerSister} egg(s)");
        Console.WriteLine($"The duckbear gets: {eggsForDuckbear} egg(s)");

        // Step 4: Answer the question about egg counts where the duckbear gets more than each sister
        Console.WriteLine("\nExamples where the duckbear gets more than each sister:");
        Console.WriteLine("Total Eggs = 5: Each sister gets 1, Duckbear gets 1");
        Console.WriteLine("Total Eggs = 9: Each sister gets 2, Duckbear gets 1");
        Console.WriteLine("Total Eggs = 13: Each sister gets 3, Duckbear gets 1");
    }
}