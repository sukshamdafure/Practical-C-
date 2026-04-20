using System;

class NumberPyramid
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

            // Increasing numbers
            for (int k = 1; k <= i; k++)
            {
                Console.Write(k);
            }

            // Decreasing numbers
            for (int k = i - 1; k >= 1; k--)
            {
                Console.Write(k);
            }

            Console.WriteLine();
        }
    }
}