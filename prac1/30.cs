using System;

class Program
{
    static void Main()
    {
        int choice;

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Addition of 10 + 5 = " + (10 + 5));
                break;

            case 2:
                Console.WriteLine("Subtraction of 10 - 5 = " + (10 - 5));
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}