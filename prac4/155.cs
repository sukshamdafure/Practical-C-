using System;
using System.Collections.Generic;

class Product
{
    public int Id;
    public string Name;
    public int Quantity;
}

class Program
{
    static List<Product> products = new List<Product>();

    static void Main()
    {
        products.Add(new Product { Id = 1, Name = "Mouse", Quantity = 10 });

        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} - {p.Name} - Qty: {p.Quantity}");
        }
    }
}