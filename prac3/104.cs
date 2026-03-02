using System;

class Person
{
    public void Show()
    {
        Console.WriteLine("This is Base Class");
    }
}

class Student : Person
{
    public void Display()
    {
        Console.WriteLine("This is Derived Class");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Show();      // Base class method
        s.Display();   // Derived class method
    }
}