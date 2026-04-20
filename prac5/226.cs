using System;

class CollatzSequence
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        Console.WriteLine("Collatz Sequence:");

        while (number != 1)
        {
            Console.Write(number + " ");

            if (number % 2 == 0)
                number /= 2;
            else
                number = 3 * number + 1;
        }

        Console.WriteLine("1");
    }
}