using System;

class CircularPrime
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

    // Function to count digits
    static int CountDigits(int n)
    {
        int count = 0;
        while (n > 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }

    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int digits = CountDigits(number);
        int temp = number;
        bool isCircularPrime = true;

        for (int i = 0; i < digits; i++)
        {
            if (!IsPrime(temp))
            {
                isCircularPrime = false;
                break;
            }

            // Rotate digits
            int lastDigit = temp % 10;
            temp = (lastDigit * (int)Math.Pow(10, digits - 1)) + (temp / 10);
        }

        if (isCircularPrime)
            Console.WriteLine("It is a Circular Prime");
        else
            Console.WriteLine("It is NOT a Circular Prime");
    }
}