using System;

class HollowSquare
{
    static void Main()
    {
        int size;

        Console.Write("Enter size of square: ");
        size = int.Parse(Console.ReadLine());

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                if (i == 1 || i == size || j == 1 || j == size)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}