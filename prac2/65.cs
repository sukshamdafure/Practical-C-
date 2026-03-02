using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string str = Console.ReadLine();

        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Number of words: " + words.Length);
    }
}
