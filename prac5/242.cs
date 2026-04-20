using System;

class CharacterPyramid
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            char ch = 'A';

            // Print spaces
            for (int j = i; j < rows; j++)
            {
                Console.Write(" ");
            }

            // Increasing characters
            for (int j = 1; j <= i; j++)
            {
                Console.Write(ch);
                ch++;
            }

            ch--; // adjust

            // Decreasing characters
            for (int j = 1; j < i; j++)
            {
                ch--;
                Console.Write(ch);
            }

            Console.WriteLine();
        }
    }
}