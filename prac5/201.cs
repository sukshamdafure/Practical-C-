using System;

class StrongNumber
{
    // Function to calculate factorial
    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    static void Main()
    {
        int number, originalNumber, remainder, sum = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        originalNumber = number;

        while (number > 0)
        {
            remainder = number % 10;
            sum += Factorial(remainder);
            number /= 10;
        }

        if (sum == originalNumber)
        {
            Console.WriteLine("It is a Strong Number");
        }
        else
        {
            Console.WriteLine("It is NOT a Strong Number");
        }
    }
}