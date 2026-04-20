using System;

class KthLargestElement
{
    static void Main()
    {
        int n, k;

        Console.Write("Enter size of array: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter value of K: ");
        k = int.Parse(Console.ReadLine());

        if (k > n)
        {
            Console.WriteLine("Invalid K value");
            return;
        }

        // Sort in descending order
        Array.Sort(arr);
        Array.Reverse(arr);

        Console.WriteLine(k + "th largest element = " + arr[k - 1]);
    }
}