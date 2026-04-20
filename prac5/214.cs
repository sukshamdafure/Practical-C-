using System;

class PerfectSquare
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int root = (int)Math.Sqrt(number);

        if (root * root == number)
            Console.WriteLine("It is a Perfect Square");
        else
            Console.WriteLine("It is NOT a Perfect Square");
    }
}