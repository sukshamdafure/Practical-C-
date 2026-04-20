using System;

class NextPrime
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

        int next = number + 1;

        while (true)
        {
            if (IsPrime(next))
            {
                Console.WriteLine("Next prime number = " + next);
                break;
            }
            next++;
        }
    }
}