using System;

class CheckPrime
{
    static void Main()
    {
        int number, count = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        if (count == 2)
            Console.WriteLine("The number is Prime.");
        else
            Console.WriteLine("The number is Not Prime.");

        Console.ReadLine();
    }
}