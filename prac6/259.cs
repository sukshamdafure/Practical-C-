using System;

class SubstringIndex
{
    static void Main()
    {
        string mainString, subString;

        Console.Write("Enter main string: ");
        mainString = Console.ReadLine();

        Console.Write("Enter substring: ");
        subString = Console.ReadLine();

        int index = mainString.IndexOf(subString);

        if (index != -1)
            Console.WriteLine("Substring found at index = " + index);
        else
            Console.WriteLine("Substring not found");
    }
}