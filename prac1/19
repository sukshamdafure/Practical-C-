using System;

class PrimeRange
{
    static void Main()
    {
        int start, end;

        Console.Write("Enter starting number: ");
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter ending number: ");
        end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers between " + start + " and " + end + " are:");

        for (int i = start; i <= end; i++)
        {
            int count = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                Console.Write(i + " ");
        }

        Console.ReadLine();
    }
}