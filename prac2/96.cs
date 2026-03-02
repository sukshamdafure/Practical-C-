using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 1 };

        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int num in arr)
        {
            if (!seen.Add(num))
            {
                duplicates.Add(num);
            }
        }

        Console.WriteLine("Duplicate Elements:");
        foreach (int num in duplicates)
        {
            Console.Write(num + " ");
        }
    }
}