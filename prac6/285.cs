using System;

class MedianOfArray
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

        // Sort array
        Array.Sort(arr);

        double median;

        if (n % 2 != 0)
        {
            median = arr[n / 2];
        }
        else
        {
            median = (arr[n / 2 - 1] + arr[n / 2]) / 2.0;
        }

        Console.WriteLine("Median of array = " + median);
    }
}