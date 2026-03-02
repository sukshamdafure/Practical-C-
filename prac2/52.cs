using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        double average = (double)sum / n;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}