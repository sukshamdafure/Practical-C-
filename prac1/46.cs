using System;

struct Student
{
    public int rollNo;
    public string name;
}

class Program
{
    static void Main()
    {
        Student s;
        s.rollNo = 1;
        s.name = "Rahul";

        Console.WriteLine("Roll No: " + s.rollNo);
        Console.WriteLine("Name: " + s.name);
    }
}