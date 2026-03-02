using System;

class AccessDemo
{
    public int a = 10;
    private int b = 20;
    protected int c = 30;
    internal int d = 40;

    public void Show()
    {
        Console.WriteLine(b); // private accessible inside class
    }
}

class Program
{
    static void Main()
    {
        AccessDemo obj = new AccessDemo();
        Console.WriteLine(obj.a);
        Console.WriteLine(obj.d);
        obj.Show();
    }
}