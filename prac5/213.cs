using System;

class Factors
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        Console.WriteLine("Factors of " + number + " are:");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}