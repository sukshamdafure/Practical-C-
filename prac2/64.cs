using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string reversed = new string(str.ToCharArray().Reverse().ToArray());

        if (str.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("String is Palindrome.");
        else
            Console.WriteLine("String is not Palindrome.");
    }
}