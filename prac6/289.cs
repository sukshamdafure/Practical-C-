using System;

class SelectionSort
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

        // Selection Sort
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        Console.WriteLine("Sorted array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}