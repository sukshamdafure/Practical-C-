using System;

class ShortestWord
{
    static void Main()
    {
        string input;

        Console.Write("Enter a sentence: ");
        input = Console.ReadLine();

        string[] words = input.Split(' ');

        string shortest = words[0];

        foreach (string word in words)
        {
            if (word.Length < shortest.Length)
            {
                shortest = word;
            }
        }

        Console.WriteLine("Shortest word = " + shortest);
    }
}
