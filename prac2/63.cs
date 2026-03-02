using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        char[] arr = str.ToCharArray();
        Array.Reverse(arr);

        Console.WriteLine("Reversed string: " + new string(arr));
    }
}