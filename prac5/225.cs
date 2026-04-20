using System;

class HappyNumber
{
    // Function to find sum of squares of digits
    static int SumOfSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }

    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int result = number;

        // Loop until result becomes 1 or 4
        while (result != 1 && result != 4)
        {
            result = SumOfSquares(result);
        }

        if (result == 1)
            Console.WriteLine("It is a Happy Number");
        else
            Console.WriteLine("It is NOT a Happy Number");
    }
}