using System;

class CubeRoot
{
    static void Main()
    {
        double number;

        Console.Write("Enter a number: ");
        number = double.Parse(Console.ReadLine());

        double cubeRoot = Math.Cbrt(number);

        Console.WriteLine("Cube root = " + cubeRoot);
    }
}