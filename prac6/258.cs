using System;

class StringRotation
{
    static void Main()
    {
        string str1, str2;

        Console.Write("Enter first string: ");
        str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        str2 = Console.ReadLine();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Not a rotation");
            return;
        }

        string combined = str1 + str1;

        if (combined.Contains(str2))
            Console.WriteLine("It is a rotation");
        else
            Console.WriteLine("It is NOT a rotation");
    }
}