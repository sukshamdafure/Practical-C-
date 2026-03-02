using System;

class GenericClass<T>
{
    public void Display(T value)
    {
        Console.WriteLine("Value: " + value);
    }
}

class Program
{
    static void Main()
    {
        GenericClass<int> obj1 = new GenericClass<int>();
        obj1.Display(100);

        GenericClass<string> obj2 = new GenericClass<string>();
        obj2.Display("Hello");
    }
}