using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine().ToLower();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine().ToLower();

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        if (new string(arr1) == new string(arr2))
            Console.WriteLine("Strings are Anagrams.");
        else
            Console.WriteLine("Strings are not Anagrams.");
    }
}