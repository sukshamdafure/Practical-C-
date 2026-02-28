using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Demonstrating break:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
                break;

            Console.WriteLine(i);
        }

        Console.WriteLine("\nDemonstrating continue:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
                continue;

            Console.WriteLine(i);
        }
    }
}