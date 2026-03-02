using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter original string: ");
        string str = Console.ReadLine();

        Console.Write("Enter substring to replace: ");
        string oldValue = Console.ReadLine();

        Console.Write("Enter new substring: ");
        string newValue = Console.ReadLine();

        string result = str.Replace(oldValue, newValue);

        Console.WriteLine("Updated String: " + result);
    }
}