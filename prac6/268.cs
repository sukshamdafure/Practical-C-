using System;

class CompareIgnoreCase
{
    static void Main()
    {
        string str1, str2;

        Console.Write("Enter first string: ");
        str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        str2 = Console.ReadLine();

        if (string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("Strings are equal (ignoring case)");
        else
            Console.WriteLine("Strings are NOT equal");
    }
}