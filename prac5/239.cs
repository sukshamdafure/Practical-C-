using System;

class ZigzagPattern
{
    static void Main()
    {
        int n;

        Console.Write("Enter length: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 3; i++) // 3 rows
        {
            for (int j = 1; j <= n; j++)
            {
                if ((i + j) % 4 == 0 || (i == 2 && j % 4 == 0))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
