// written by Mamoutou Kane 
// date: 02/16/2025
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(FlipEndChars("Cat, dog, and mouse."));  
        Console.WriteLine(FlipEndChars("ada"));  
        Console.WriteLine(FlipEndChars("Ada"));  
        Console.WriteLine(FlipEndChars("z")); 
    }

    static string FlipEndChars(string str)
    {
        if (str.Length < 2)
        {
            return "Incompatible.";
        }
        if (str[0] == str[str.Length - 1])
        {
            return "Two's a pair.";
        }

        char first = str[0];
        char last = str[str.Length - 1];

        return last + str.Substring(1, str.Length - 2) + first;
    }
}

