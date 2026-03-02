using System;

class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent Show Method");
    }
}

class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("Child Show Method");
    }
}

class Program
{
    static void Main()
    {
        Parent obj = new Child();
        obj.Show();
    }
}