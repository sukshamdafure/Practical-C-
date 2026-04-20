using System;

class ToggleCase
{
    static void Main()
    {
        string input, result = "";

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (ch >= 'A' && ch <= 'Z')
            {
                result += (char)(ch + 32); // uppercase to lowercase
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                result += (char)(ch - 32); // lowercase to uppercase
            }
            else
            {
                result += ch; // keep symbols/spaces unchanged
            }
        }

        Console.WriteLine("Toggled string = " + result);
    }
}