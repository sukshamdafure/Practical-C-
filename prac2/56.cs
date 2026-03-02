using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of first array: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n1];

        Console.WriteLine("Enter elements of first array:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter size of second array: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] arr2 = new int[n2];

        Console.WriteLine("Enter elements of second array:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        int[] merged = new int[n1 + n2];

        for (int i = 0; i < n1; i++)
        {
            merged[i] = arr1[i];
        }

        for (int i = 0; i < n2; i++)
        {
            merged[n1 + i] = arr2[i];
        }

        Console.WriteLine("Merged array:");
        foreach (int item in merged)
        {
            Console.Write(item + " ");
        }
    }
}