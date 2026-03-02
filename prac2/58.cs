using System;

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

        Console.Write("Enter element to search: ");
        int key = int.Parse(Console.ReadLine());

        int position = -1;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == key)
            {
                position = i;
                break;
            }
        }

        if (position != -1)
            Console.WriteLine("Element found at position: " + (position + 1));
        else
            Console.WriteLine("Element not found.");
    }
}