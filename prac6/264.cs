using System;

class CountSpecialCharacters
{
    static void Main()
    {
        string input;
        int count = 0;

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (!char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch))
            {
                count++;
            }
        }

        Console.WriteLine("Number of special characters = " + count);
    }
}