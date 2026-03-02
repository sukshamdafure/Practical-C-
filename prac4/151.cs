using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Student\n2. View Students\n3. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: ViewStudents(); break;
                case 3: return;
            }
        }
    }

    static void AddStudent()
    {
        Student s = new Student();
        Console.Write("Id: ");
        s.Id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        s.Name = Console.ReadLine();
        Console.Write("Marks: ");
        s.Marks = int.Parse(Console.ReadLine());

        students.Add(s);
    }

    static void ViewStudents()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Marks}");
        }
    }
}