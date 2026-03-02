using System;

class Sample
{
    public Sample()
    {
        Console.WriteLine("Constructor Executed");
    }

    ~Sample()
    {
        Console.WriteLine("Destructor Executed");
    }
}

class Program
{
    static void Main()
    {
        Sample obj = new Sample();
        Console.WriteLine("Object Created");
    }
}