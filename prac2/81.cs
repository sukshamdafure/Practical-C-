using System;

class Program
{
    static void DisplayArray(int[] arr)
    {
        Console.WriteLine("Array elements:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        DisplayArray(numbers);
    }
}