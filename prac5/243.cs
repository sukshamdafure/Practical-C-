using System;

class RightAlignedTriangle
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = i; j < rows; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}