using System;

class Publisher
{
    public event Action OnProcess;

    public void Start()
    {
        Console.WriteLine("Process Started");
        OnProcess?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Publisher p = new Publisher();
        p.OnProcess += () => Console.WriteLine("Event Triggered!");
        p.Start();
    }
}