using System;

class Checkerboard
{
    static void Main()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= cols; j++)
            {
                if ((i + j) % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}