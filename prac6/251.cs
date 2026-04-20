using System;

class PangramCheck
{
    static void Main()
    {
        string input;

        Console.Write("Enter a string: ");
        input = Console.ReadLine().ToLower();

        bool[] alphabet = new bool[26];

        // Mark letters present in string
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'a' && input[i] <= 'z')
            {
                alphabet[input[i] - 'a'] = true;
            }
        }

        // Check if all letters are present
        bool isPangram = true;

        for (int i = 0; i < 26; i++)
        {
            if (!alphabet[i])
            {
                isPangram = false;
                break;
            }
        }

        if (isPangram)
            Console.WriteLine("It is a Pangram");
        else
            Console.WriteLine("It is NOT a Pangram");
    }
}