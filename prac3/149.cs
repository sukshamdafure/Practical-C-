using System;

[Obsolete("This method is outdated")]
class OldClass
{
    public void Show()
    {
        Console.WriteLine("Old Method");
    }
}

class Program
{
    static void Main()
    {
        OldClass obj = new OldClass();
        obj.Show();
    }
}