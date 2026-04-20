using System;

class ReverseNumber
{
    static int reverse = 0;

    static int ReverseDigits(int n)
    {
        if (n == 0)
            return reverse;

        int remainder = n % 10;
        reverse = reverse * 10 + remainder;

        return ReverseDigits(n / 10);
    }

    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int result = ReverseDigits(number);

        Console.WriteLine("Reversed number = " + result);
    }
}