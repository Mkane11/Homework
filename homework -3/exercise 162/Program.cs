// written by Mamoutou Kane
// date: 02/16/2025
using System;

class Arrow
{
    private float length;
    private string material;
    private string tip;

    public Arrow(float length, string material, string tip)
    {
        this.length = length;
        this.material = material;
        this.tip = tip;
    }

    public float GetLength()
    {
        return length;
    }

    public string GetMaterial()
    {
        return material;
    }

    public string GetTip()
    {
        return tip;
    }
}

class Program
{
    static void Main()
    {
        Arrow arrow = new Arrow(30.5f, "Wood", "Steel");
        Console.WriteLine($"Arrow Length: {arrow.GetLength()} inches");
        Console.WriteLine($"Arrow Material: {arrow.GetMaterial()}");
        Console.WriteLine($"Arrow Tip: {arrow.GetTip()}");
    }
}

