using System;

class ReverseNumber
{
    static void Main()
    {
        int number, reverse = 0, remainder;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number /= 10;
        }

        Console.WriteLine("Reversed Number = " + reverse);
        Console.ReadLine();
    }
}