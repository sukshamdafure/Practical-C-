using System;

class CapitalizeWords
{
    static void Main()
    {
        string input;

        Console.Write("Enter a sentence: ");
        input = Console.ReadLine();

        string[] words = input.Split(' ');
        string result = "";

        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                string capitalized =
                    char.ToUpper(word[0]) + word.Substring(1);

                result += capitalized + " ";
            }
        }

        Console.WriteLine("Result = " + result.Trim());
    }
}