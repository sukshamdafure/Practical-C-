using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 5 };  // Missing 4

        int n = arr.Length + 1;
        int expectedSum = n * (n + 1) / 2;

        int actualSum = 0;
        foreach (int num in arr)
        {
            actualSum += num;
        }

        Console.WriteLine("Missing Number: " + (expectedSum - actualSum));
    }
}