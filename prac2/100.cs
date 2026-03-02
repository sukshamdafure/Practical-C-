using System;

class Program
{
    static void Main()
    {
        // Creating objects
        for (int i = 0; i < 5; i++)
        {
            Sample obj = new Sample();
            Console.WriteLine("Object Created");
        }

        // Forcing Garbage Collection
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Garbage Collection Invoked");
    }
}

class Sample
{
    ~Sample()
    {
        Console.WriteLine("Object Destroyed (Finalizer Called)");
    }
}