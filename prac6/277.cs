using System;
using System.Collections.Generic;

class ArrayUnion
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Enter size of first array: ");
        n1 = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n1];

        Console.WriteLine("Enter elements of first array:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter size of second array: ");
        n2 = int.Parse(Console.ReadLine());

        int[] arr2 = new int[n2];

        Console.WriteLine("Enter elements of second array:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        HashSet<int> unionSet = new HashSet<int>();

        // Add elements of first array
        for (int i = 0; i < n1; i++)
        {
            unionSet.Add(arr1[i]);
        }

        // Add elements of second array
        for (int i = 0; i < n2; i++)
        {
            unionSet.Add(arr2[i]);
        }

        Console.WriteLine("Union of arrays:");

        foreach (int item in unionSet)
        {
            Console.Write(item + " ");
        }
    }
}