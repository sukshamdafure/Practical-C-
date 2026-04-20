using System;

class DiamondPattern
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

            // Stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
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

            // Stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}