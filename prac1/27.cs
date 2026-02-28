using System;

class Demo
{
    const double PI = 3.14;      // Constant
    readonly int number;         // Readonly variable

    public Demo(int num)
    {
        number = num;            // Assigned in constructor
    }

    static void Main()
    {
        Demo obj = new Demo(10);

        Console.WriteLine("Constant PI: " + PI);
        Console.WriteLine("Readonly number: " + obj.number);
    }
}