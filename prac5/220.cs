using System;

class DigitalRoot
{
    static void Main()
    {
        int number, sum;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 9)
        {
            sum = 0;

            while (number > 0)
            {
                sum += number % 10;  // extract digit
                number /= 10;
            }

            number = sum;  // repeat process
        }

        Console.WriteLine("Digital Root = " + number);
    }
}