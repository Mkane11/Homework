// written by Mamoutou Kane
// date: 02/16/2025
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsInOrder("abc")); 
        Console.WriteLine(IsInOrder("edabit"));  
        Console.WriteLine(IsInOrder("123"));  
        Console.WriteLine(IsInOrder("xyzz")); 
    }

    static bool IsInOrder(string str)
    {
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] > str[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}

