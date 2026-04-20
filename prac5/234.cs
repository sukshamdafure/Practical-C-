using System;

class FloydTriangle
{
    static void Main()
    {
        int rows, num = 1;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}