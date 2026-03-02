using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[2, 2];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Transpose of matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(matrix[j, i] + " ");
            Console.WriteLine();
        }
    }
}