using System;

partial class Student
{
    public void Part1()
    {
        Console.WriteLine("This is Part 1");
    }
}

partial class Student
{
    public void Part2()
    {
        Console.WriteLine("This is Part 2");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Part1();
        s.Part2();
    }
}