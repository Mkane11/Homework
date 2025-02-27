// written by Mamoutou Kane
// Date: 02/02/2025

using System;

class RepairingTheClocktower
{
    static void Main()
    {
        // Step 1: Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); // Read and convert input to an integer

        // Step 2: Check if the number is even or odd using the modulus operator
        if (number % 2 == 0)
        {
            // Step 3: Display "Tick" if even
            Console.WriteLine("Tick");
        }
        else
        {
            // Step 4: Display "Tock" if odd
            Console.WriteLine("Tock");
        }
    }
}