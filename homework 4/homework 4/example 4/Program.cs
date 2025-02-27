// written by Mamoutou Kane
// date: 02/16/2025
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine(FirstNVowels("sharpening skills", 3)); 
        Console.WriteLine(FirstNVowels("major league", 5));  
        Console.WriteLine(FirstNVowels("hostess", 5));  
    }

    static string FirstNVowels(string str, int n)
    {
        string vowels = "aeiou";
        StringBuilder result = new StringBuilder();

        foreach (char c in str)
        {
            if (vowels.Contains(c))
            {
                result.Append(c);
                if (result.Length == n)
                {
                    return result.ToString();
                }
            }
        }

        return "invalid";  // Return "invalid" if there are not enough vowels
    }
}

