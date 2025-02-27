// written by Mamoutou Kane
// date: 02/16/2025
using System;

class Arrow
{
    public enum ArrowheadType { Steel, Wood, Obsidian }
    public enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers }

    public ArrowheadType Arrowhead { get; }
    public FletchingType Fletching { get; }
    public int Length { get; }

    public Arrow(ArrowheadType arrowhead, FletchingType fletching, int length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float GetCost()
    {
        float cost = 0;

        // Calculate arrowhead cost
        cost += Arrowhead switch
        {
            ArrowheadType.Steel => 10,
            ArrowheadType.Wood => 3,
            ArrowheadType.Obsidian => 5,
            _ => 0
        };

        // Calculate fletching cost
        cost += Fletching switch
        {
            FletchingType.Plastic => 10,
            FletchingType.TurkeyFeathers => 5,
            FletchingType.GooseFeathers => 3,
            _ => 0
        };

        // Calculate shaft cost
        cost += 0.05f * Length;

        return cost;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Vin Fletcher's Arrow Shop!");

        Arrow.ArrowheadType arrowhead = GetArrowheadType();
        Arrow.FletchingType fletching = GetFletchingType();
        int length = GetShaftLength();

        Arrow arrow = new Arrow(arrowhead, fletching, length);
        float cost = arrow.GetCost();

        Console.WriteLine($"\nArrow Details:");
        Console.WriteLine($"Arrowhead: {arrow.Arrowhead}");
        Console.WriteLine($"Fletching: {arrow.Fletching}");
        Console.WriteLine($"Length: {arrow.Length} cm");
        Console.WriteLine($"Total Cost: {cost:F2} gold");
    }

    static Arrow.ArrowheadType GetArrowheadType()
    {
        Console.WriteLine("\nChoose an arrowhead type:");
        Console.WriteLine("1. Steel");
        Console.WriteLine("2. Wood");
        Console.WriteLine("3. Obsidian");
        while (true)
        {
            Console.Write("Enter your choice (1-3): ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
                return (Arrow.ArrowheadType)(choice - 1);
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    static Arrow.FletchingType GetFletchingType()
    {
        Console.WriteLine("\nChoose a fletching type:");
        Console.WriteLine("1. Plastic");
        Console.WriteLine("2. Turkey Feathers");
        Console.WriteLine("3. Goose Feathers");
        while (true)
        {
            Console.Write("Enter your choice (1-3): ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
                return (Arrow.FletchingType)(choice - 1);
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    static int GetShaftLength()
    {
        while (true)
        {
            Console.Write("\nEnter arrow shaft length (60-100 cm): ");
            if (int.TryParse(Console.ReadLine(), out int length) && length >= 60 && length <= 100)
                return length;
            Console.WriteLine("Invalid length. Please enter a number between 60 and 100.");
        }
    }
}
