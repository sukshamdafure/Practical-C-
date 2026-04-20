using System;
using System.Collections.Generic;

class ArrayIntersection
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

        HashSet<int> set = new HashSet<int>(arr2);

        Console.WriteLine("Intersection of arrays:");

        HashSet<int> printed = new HashSet<int>();

        for (int i = 0; i < n1; i++)
        {
            if (set.Contains(arr1[i]) && !printed.Contains(arr1[i]))
            {
                Console.Write(arr1[i] + " ");
                printed.Add(arr1[i]);
            }
        }
    }
}