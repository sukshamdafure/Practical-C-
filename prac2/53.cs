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

        int largest = arr[0];
        int smallest = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > largest)
                largest = arr[i];

            if (arr[i] < smallest)
                smallest = arr[i];
        }

        Console.WriteLine("Largest element = " + largest);
        Console.WriteLine("Smallest element = " + smallest);
    }
}