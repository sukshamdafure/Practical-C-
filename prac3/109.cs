using System;

interface IFly
{
    void Fly();
}

interface ISwim
{
    void Swim();
}

class Duck : IFly, ISwim
{
    public void Fly()
    {
        Console.WriteLine("Duck can Fly");
    }

    public void Swim()
    {
        Console.WriteLine("Duck can Swim");
    }
}

class Program
{
    static void Main()
    {
        Duck d = new Duck();
        d.Fly();
        d.Swim();
    }
}