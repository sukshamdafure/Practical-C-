using System;

class LongestWord
{
    static void Main()
    {
        string input;

        Console.Write("Enter a sentence: ");
        input = Console.ReadLine();

        string[] words = input.Split(' ');

        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        Console.WriteLine("Longest word = " + longest);
    }
}