using System;
using System.Threading;

class Program
{
    static object lockObj = new object();

    static void Print()
    {
        lock (lockObj)
        {
            Console.WriteLine("Synchronized Block");
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Print);
        Thread t2 = new Thread(Print);

        t1.Start();
        t2.Start();
    }
}