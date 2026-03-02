using System;

class GenericClass<T> where T : class
{
    public void Show(T item)
    {
        Console.WriteLine(item.ToString());
    }
}

class Program
{
    static void Main()
    {
        GenericClass<string> obj = new GenericClass<string>();
        obj.Show("Constraint Example");
    }
}