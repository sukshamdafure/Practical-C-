using System;

class Program
{
    static void CheckNumber(int num)
    {
        if (num < 0)
            throw new ArgumentException("Number cannot be negative.");
    }

    static void Main()
    {
        try
        {
            CheckNumber(-5);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}