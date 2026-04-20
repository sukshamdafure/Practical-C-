using System;

class NumericDiamond
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        // Upper Pyramid
        for (int i = 1; i <= rows; i++)
        {
            // Spaces
            for (int j = i; j < rows; j++)
            {
                Console.Write(" ");
            }

            // Increasing numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            // Decreasing numbers
            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        // Lower Inverted Pyramid
        for (int i = rows - 1; i >= 1; i--)
        {
            // Spaces
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }

            // Increasing numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            // Decreasing numbers
            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}