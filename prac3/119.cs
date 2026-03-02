using System;

class Invoice
{
    public void CalculateTotal()
    {
        Console.WriteLine("Calculating Invoice Total");
    }
}

class InvoicePrinter
{
    public void Print()
    {
        Console.WriteLine("Printing Invoice");
    }
}

class Program
{
    static void Main()
    {
        Invoice inv = new Invoice();
        inv.CalculateTotal();

        InvoicePrinter printer = new InvoicePrinter();
        printer.Print();
    }
}