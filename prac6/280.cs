using System;

class MoveZerosToEnd
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

        int j = 0; // index for non-zero elements

        // Move non-zero elements forward
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                arr[j] = arr[i];
                j++;
            }
        }

        // Fill remaining with zeros
        while (j < n)
        {
            arr[j] = 0;
            j++;
        }

        Console.WriteLine("Array after moving zeros to end:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}