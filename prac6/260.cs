using System;

class StringCompression
{
    static void Main()
    {
        string input;

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        string result = "";
        int count = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i + 1 < input.Length && input[i] == input[i + 1])
            {
                count++;
            }
            else
            {
                result += input[i] + count.ToString();
                count = 1;
            }
        }

        Console.WriteLine("Compressed string = " + result);
    }
}