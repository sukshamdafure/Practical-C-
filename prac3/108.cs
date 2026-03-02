using System;

interface IPrintable
{
    void Print();
}

class Document : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing Document");
    }
}

class Program
{
    static void Main()
    {
        IPrintable obj = new Document();
        obj.Print();
    }
}