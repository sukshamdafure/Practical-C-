using System;

class StringToCharArray
{
    static void Main()
    {
        string input;

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        char[] charArray = input.ToCharArray();

        Console.WriteLine("Character Array:");

        for (int i = 0; i < charArray.Length; i++)
        {
            Console.Write(charArray[i] + " ");
        }
    }
}