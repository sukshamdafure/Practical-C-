using System;

class HollowTriangle
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i == 1 || i == rows || j == 1 || j == i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}