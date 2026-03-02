using System;

class Student
{
    string name;

    // Constructor
    public Student(string n)
    {
        name = n;
        Console.WriteLine("Constructor Called");
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Suksham");
        s1.Display();
    }
}