using System;

class ExtractNumbers
{
    static void Main()
    {
        string input, result = "";

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                result += input[i];
            }
        }

        Console.WriteLine("Extracted numbers = " + result);
    }
}