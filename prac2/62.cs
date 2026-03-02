using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine().ToLower();

        int count = 0;

        foreach (char ch in str)
        {
            if ("aeiou".Contains(ch))
                count++;
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}