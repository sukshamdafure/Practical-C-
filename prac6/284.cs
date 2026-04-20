using System;

class MergeSortedArrays
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Enter size of first array: ");
        n1 = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n1];

        Console.WriteLine("Enter elements of first sorted array:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter size of second array: ");
        n2 = int.Parse(Console.ReadLine());

        int[] arr2 = new int[n2];

        Console.WriteLine("Enter elements of second sorted array:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        int[] merged = new int[n1 + n2];

        int i1 = 0, i2 = 0, k = 0;

        while (i1 < n1 && i2 < n2)
        {
            if (arr1[i1] <= arr2[i2])
            {
                merged[k++] = arr1[i1++];
            }
            else
            {
                merged[k++] = arr2[i2++];
            }
        }

        // Copy remaining elements
        while (i1 < n1)
        {
            merged[k++] = arr1[i1++];
        }

        while (i2 < n2)
        {
            merged[k++] = arr2[i2++];
        }

        Console.WriteLine("Merged Sorted Array:");

        for (int i = 0; i < k; i++)
        {
            Console.Write(merged[i] + " ");
        }
    }
}