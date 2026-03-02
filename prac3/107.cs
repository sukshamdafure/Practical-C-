using System;

abstract class Vehicle
{
    public abstract void Start();
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car Started");
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Car();
        v.Start();
    }
}