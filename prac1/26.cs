using System;

class Program
{
    static void Main()
    {
        // Implicit Casting (smaller to larger type)
        int num = 100;
        double d = num;
        Console.WriteLine("Implicit Casting (int to double): " + d);

        // Explicit Casting (larger to smaller type)
        double x = 123.45;
        int y = (int)x;
        Console.WriteLine("Explicit Casting (double to int): " + y);

        // Using Convert Method
        string str = "50";
        int n = Convert.ToInt32(str);
        Console.WriteLine("String to int using Convert: " + n);
    }
}