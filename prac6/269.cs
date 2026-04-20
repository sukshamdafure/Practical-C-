using System;
using System.Collections.Generic;

class RemoveDuplicateWords
{
    static void Main()
    {
        string input;

        Console.Write("Enter a sentence: ");
        input = Console.ReadLine();

        string[] words = input.Split(' ');

        HashSet<string> seen = new HashSet<string>();
        string result = "";

        foreach (string word in words)
        {
            string lowerWord = word.ToLower();

            if (!seen.Contains(lowerWord))
            {
                seen.Add(lowerWord);
                result += word + " ";
            }
        }

        Console.WriteLine("After removing duplicate words = " + result.Trim());
    }
}