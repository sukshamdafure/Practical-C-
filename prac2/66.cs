using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char ch in str)
        {
            if (freq.ContainsKey(ch))
                freq[ch]++;
            else
                freq[ch] = 1;
        }

        Console.WriteLine("Character Frequencies:");
        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}