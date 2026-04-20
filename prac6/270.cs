using System;

class ReverseWords
{
    static void Main()
    {
        string input;

        Console.Write("Enter a sentence: ");
        input = Console.ReadLine();

        string[] words = input.Split(' ');

        Console.WriteLine("Reversed sentence:");

        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
    }
}