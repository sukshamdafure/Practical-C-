using System;

class RemoveDuplicates
{
    static void Main()
    {
        string input, result = "";

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            // Check if character already exists in result
            if (!result.Contains(ch.ToString()))
            {
                result += ch;
            }
        }

        Console.WriteLine("String after removing duplicates = " + result);
    }
}