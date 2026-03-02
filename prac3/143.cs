using System;
using System.Threading;

class Program
{
    static void Print()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread: " + i);
        }
    }

    static void Main()
    {
        Thread t = new Thread(Print);
        t.Start();
    }
}