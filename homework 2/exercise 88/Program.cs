// written by Mamoutou Kane
// Date: 02/06/2025

using System;

class Program
{
    static void Main()
    {
        int pilotNumber;

        // Get pilot's number
        while (true)
        {
            Console.Write("User 1, enter a number between 0 and 100: ");
            if (int.TryParse(Console.ReadLine(), out pilotNumber) && pilotNumber >= 0 && pilotNumber <= 100)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }

        Console.Clear();

        // Hunter's guessing loop
        int hunterGuess;
        do
        {
            Console.Write("User 2, guess the number.\nWhat is your next guess? ");
            while (!int.TryParse(Console.ReadLine(), out hunterGuess))
            {
                Console.Write("Invalid input. Please enter a number: ");
            }

            if (hunterGuess > pilotNumber)
            {
                Console.WriteLine($"{hunterGuess} is too high.");
            }
            else if (hunterGuess < pilotNumber)
            {
                Console.WriteLine($"{hunterGuess} is too low.");
            }
            else
            {
                Console.WriteLine("You guessed the number!");
            }
        } while (hunterGuess != pilotNumber);
    }
}

