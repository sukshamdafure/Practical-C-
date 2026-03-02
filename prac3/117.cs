using System;

abstract class Animal
{
    public abstract void Sound();
    public void Sleep()
    {
        Console.WriteLine("Animal Sleeping");
    }
}

interface IFly
{
    void Fly();
}

class Bird : Animal, IFly
{
    public override void Sound()
    {
        Console.WriteLine("Bird Sound");
    }

    public void Fly()
    {
        Console.WriteLine("Bird Flying");
    }
}

class Program
{
    static void Main()
    {
        Bird b = new Bird();
        b.Sound();
        b.Sleep();
        b.Fly();
    }
}