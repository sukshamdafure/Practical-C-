using System;

class EquilibriumIndex
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

        int totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            totalSum += arr[i];
        }

        int leftSum = 0;
        bool found = false;

        for (int i = 0; i < n; i++)
        {
            totalSum -= arr[i]; // right sum = remaining total

            if (leftSum == totalSum)
            {
                Console.WriteLine("Equilibrium index found at position: " + i);
                found = true;
            }

            leftSum += arr[i];
        }

        if (!found)
        {
            Console.WriteLine("No equilibrium index found");
        }
    }
}