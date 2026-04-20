using System;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int n;

        Console.Write("Enter size of array: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int[] lis = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            lis[i] = 1; // every element is a subsequence of length 1
        }

        int max = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
            if (lis[i] > max)
                max = lis[i];
        }

        Console.WriteLine("Length of Longest Increasing Subsequence = " + max);
    }
}