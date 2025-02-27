// written by Mamoutou Kane
// date: 02/06/2025

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The following items are available:");
        Console.WriteLine("1 – Rope");
        Console.WriteLine("2 – Torches");
        Console.WriteLine("3 – Climbing Equipment");
        Console.WriteLine("4 – Clean Water");
        Console.WriteLine("5 – Machete");
        Console.WriteLine("6 – Canoe");
        Console.WriteLine("7 – Food Supplies");
        Console.WriteLine("What number do you want to see the price of?");

        int choice = Convert.ToInt32(Console.ReadLine());

        string item;
        int price;

        switch (choice)
        {
            case 1:
                item = "Rope";
                price = 10;
                break;
            case 2:
                item = "Torches";
                price = 15;
                break;
            case 3:
                item = "Climbing Equipment";
                price = 24;
                break;
            case 4:
                item = "Clean Water";
                price = 2;
                break;
            case 5:
                item = "Machete";
                price = 20;
                break;
            case 6:
                item = "Canoe";
                price = 200;
                break;
            case 7:
                item = "Food Supplies";
                price = 2;
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 7.");
                return;
        }

        Console.WriteLine($"{item} cost {price} gold.");
    }
}
