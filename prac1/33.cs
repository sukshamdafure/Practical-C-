using System;

class Program
{
    static void Main()
    {
        int i = 1;

        Console.WriteLine("Do-While Loop Example:");

        do
        {
            Console.WriteLine("Iteration: " + i);
            i++;
        }
        while (i <= 5);
    }
}