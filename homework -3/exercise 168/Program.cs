// written by Mamoutou Kane
// date: 02/16/2025
using System;

class Arrow
{
    public string Arrowhead { get; set; } 
    public string Fletching { get; set; } 
    public float Length { get; set; } 

    public Arrow(string arrowhead, string fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public void DisplayArrow()
    {
        Console.WriteLine($"Arrow Details:\nArrowhead: {Arrowhead}\nFletching: {Fletching}\nLength: {Length} cm");
    }
}

class Program
{
    static void Main()
    {
        Arrow myArrow = new Arrow("Steel", "Goose Feathers", 75);
        myArrow.DisplayArrow();
    }
}
