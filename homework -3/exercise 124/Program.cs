// written by Mamoutou Kane
// date: 02/16/2025
using System;

class ManticoreHunt
{
    static void Main()
    {
        int cityHealth = 15;
        int manticoreHealth = 10;
        int round = 1;

        int manticoreDistance = GetManticoreDistance();
        Console.Clear();

        Console.WriteLine("Player 2, it is your turn.");

        while (cityHealth > 0 && manticoreHealth > 0)
        {
            DisplayStatus(round, cityHealth, manticoreHealth);
            int damage = CalculateDamage(round);
            DisplayExpectedDamage(damage);

            int targetRange = GetTargetRange();
            string result = CheckShot(targetRange, manticoreDistance);
            DisplayShotResult(result);

            if (result == "DIRECT HIT")
                manticoreHealth -= damage;

            if (manticoreHealth > 0)
                cityHealth--;

            round++;
        }

        DisplayGameResult(cityHealth > 0);
    }

    static int GetManticoreDistance()
    {
        return GetNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
    }

    static void DisplayStatus(int round, int cityHealth, int manticoreHealth)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    }

    static int CalculateDamage(int round)
    {
        if (round % 3 == 0 && round % 5 == 0) return 10;
        if (round % 3 == 0 || round % 5 == 0) return 3;
        return 1;
    }

    static void DisplayExpectedDamage(int damage)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    }

    static int GetTargetRange()
    {
        return GetNumberInRange("Enter desired cannon range:", 0, 100);
    }

    static string CheckShot(int targetRange, int manticoreDistance)
    {
        if (targetRange < manticoreDistance) return "FELL SHORT";
        if (targetRange > manticoreDistance) return "OVERSHOT";
        return "DIRECT HIT";
    }

    static void DisplayShotResult(string result)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"That round {result} the target.");
    }

    static void DisplayGameResult(bool cityWon)
    {
        Console.ForegroundColor = cityWon ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine(cityWon
            ? "The Manticore has been destroyed! The city of Consolas has been saved!"
            : "The city has been destroyed. The Manticore and the Uncoded One have won.");
    }

    static int GetNumberInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{prompt} ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (int.TryParse(Console.ReadLine(), out int number) && number >= min && number <= max)
                return number;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Please enter a number between {min} and {max}.");
        }
    }
}
