using System;

class Program
{
    static void Main()
    {
        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        int[,] result = new int[2, 2];

        Console.WriteLine("Enter elements of first matrix:");
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                a[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of second matrix:");
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                b[i, j] = int.Parse(Console.ReadLine());

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    result[i, j] += a[i, k] * b[k, j];

        Console.WriteLine("Multiplication result:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(result[i, j] + " ");
            Console.WriteLine();
        }
    }
}