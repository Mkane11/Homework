// written by Mamoutou Kane
// date: 02/16/2025
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(CountWords("Just an example here move along"));  // Output: 6
        Console.WriteLine(CountWords("This is a test"));  // Output: 4
        Console.WriteLine(CountWords("What an easy task, right"));  // Output: 5
    }

    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}

