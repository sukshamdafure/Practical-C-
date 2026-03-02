using System;
using System.Collections.Generic;

class ERP
{
    public List<string> Employees = new List<string>();
    public List<string> Products = new List<string>();
}

class Program
{
    static void Main()
    {
        ERP erp = new ERP();
        erp.Employees.Add("Suksham");
        erp.Products.Add("Laptop");

        Console.WriteLine("ERP System Running");
    }
}