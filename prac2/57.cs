using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        HashSet<int> uniqueElements = new HashSet<int>(arr);

        Console.WriteLine("Array after removing duplicates:");
        foreach (int item in uniqueElements)
        {
            Console.Write(item + " ");
        }
    }
}