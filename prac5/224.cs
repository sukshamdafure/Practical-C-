using System;

class PreviousPrime
{
    // Function to check prime
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int prev = number - 1;

        while (prev >= 2 && !IsPrime(prev))
        {
            prev--;
        }

        if (prev >= 2)
            Console.WriteLine("Previous Prime Number = " + prev);
        else
            Console.WriteLine("No previous prime exists");
    }
}