using System;

delegate void MyDelegate();

class Program
{
    static void Method1() => Console.WriteLine("Method 1");
    static void Method2() => Console.WriteLine("Method 2");

    static void Main()
    {
        MyDelegate del = Method1;
        del += Method2;   // Multicast
        del();
    }
}