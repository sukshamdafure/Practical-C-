using System;

class CountConsonants
{
    static void Main()
    {
        string input;
        int count = 0;

        Console.Write("Enter a string: ");
        input = Console.ReadLine().ToLower();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (ch >= 'a' && ch <= 'z')
            {
                if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u')
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Number of consonants = " + count);
    }
}