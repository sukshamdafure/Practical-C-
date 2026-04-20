using System;

class AutomorphicNumber
{
    static void Main()
    {
        int number, square, temp;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        square = number * number;
        temp = number;

        while (temp > 0)
        {
            if ((temp % 10) != (square % 10))
            {
                Console.WriteLine("It is NOT an Automorphic Number");
                return;
            }

            temp /= 10;
            square /= 10;
        }

        Console.WriteLine("It is an Automorphic Number");
    }
}