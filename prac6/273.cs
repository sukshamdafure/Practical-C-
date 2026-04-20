using System;

class PairWithSum
{
    static void Main()
    {
        int n, sum;

        Console.Write("Enter size of array: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter target sum: ");
        sum = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == sum)
                {
                    Console.WriteLine("Pair found: " + arr[i] + " + " + arr[j]);
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No pair found");
        }
    }
}