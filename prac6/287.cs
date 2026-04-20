using System;
using System.Collections.Generic;

class FindDuplicatesHashSet
{
    static void Main()
    {
        int n;

        Console.Write("Enter size of array: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            if (!seen.Add(arr[i]))
            {
                duplicates.Add(arr[i]);
            }
        }

        Console.WriteLine("Duplicate elements:");

        foreach (int item in duplicates)
        {
            Console.Write(item + " ");
        }
    }
}