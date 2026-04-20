using System;

class ExpandString
{
    static void Main()
    {
        string input;

        Console.Write("Enter compressed string: ");
        input = Console.ReadLine();

        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            // Get the number after the character
            if (i + 1 < input.Length)
            {
                int count = 0;

                // handle multi-digit numbers also
                while (i + 1 < input.Length && char.IsDigit(input[i + 1]))
                {
                    count = count * 10 + (input[i + 1] - '0');
                    i++;
                }

                for (int j = 0; j < count; j++)
                {
                    result += ch;
                }
            }
        }

        Console.WriteLine("Expanded string = " + result);
    }
}