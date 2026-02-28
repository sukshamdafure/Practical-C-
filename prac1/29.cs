using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Number is Positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Number is Negative");
        }
        else
        {
            Console.WriteLine("Number is Zero");
        }
    }
}