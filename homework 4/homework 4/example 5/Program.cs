// written by Mamoutou kane
// Date: 02/16/2025
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Move("hello"));  
        Console.WriteLine(Move("bye"));  
        Console.WriteLine(Move("welcome"));  
    }

    static string Move(string str)
    {
        char[] result = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            result[i] = (char)(str[i] + 1);  
        }

        return new string(result);
    }
}

