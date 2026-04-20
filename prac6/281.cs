using System;

class SegregateEvenOdd
{
    static void Main()
    {
        int n;

        Console.Write("Enter size of array: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int[] result = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int index = 0;

        // First add even numbers
        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
            {
                result[index] = arr[i];
                index++;
            }
        }

        // Then add odd numbers
        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 != 0)
            {
                result[index] = arr[i];
                index++;
            }
        }

        Console.WriteLine("Array after segregating even and odd:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}