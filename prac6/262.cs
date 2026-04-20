using System;

class RemoveVowels
{
    static void Main()
    {
        string input, result = "";

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        input = input.ToLower();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u')
            {
                result += ch;
            }
        }

        Console.WriteLine("String after removing vowels = " + result);
    }
}