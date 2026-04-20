using System;

class PascalTriangle
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            int number = 1;

            // Print spaces
            for (int j = 0; j < rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print numbers
            for (int j = 0; j <= i; j++)
            {
                Console.Write(number + " ");
                number = number * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }
}