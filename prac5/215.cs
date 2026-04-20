using System;

class PerfectCube
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        double root = Math.Cbrt(number);
        int cubeRoot = (int)Math.Round(root);

        if (cubeRoot * cubeRoot * cubeRoot == number)
            Console.WriteLine("It is a Perfect Cube");
        else
            Console.WriteLine("It is NOT a Perfect Cube");
    }
}