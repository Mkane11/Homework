// written by Mamoutou Kane
// date: 02/06/2025

using System;

class ReplicatorOfDTo
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Replicator of D'To!");

        // Create the first array of length 5
        int[] originalArray = new int[5];

        // Ask the user for five numbers and put them in the array
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            originalArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Create the second array of length 5
        int[] replicatedArray = new int[5];

        // Use a loop to copy the values from the original array to the new one
        for (int i = 0; i < 5; i++)
        {
            replicatedArray[i] = originalArray[i];
        }

        // Display the contents of both arrays
        Console.WriteLine("\nOriginal Array:");
        DisplayArray(originalArray);

        Console.WriteLine("\nReplicated Array:");
        DisplayArray(replicatedArray);

        Console.WriteLine("\nThe Replicator of D'To works again!");
    }

    static void DisplayArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

