using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        Console.WriteLine("Words in the string:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}