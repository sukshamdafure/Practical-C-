using System;

class Program
{
    static void Main()
    {
        string str = "Hello";
        string newStr = str.Replace("H", "J");

        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Modified String: " + newStr);
    }
}