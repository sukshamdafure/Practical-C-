using System;

class Student
{
    private int marks;   // data hidden

    public void SetMarks(int m)
    {
        if (m >= 0 && m <= 100)
            marks = m;
    }

    public int GetMarks()
    {
        return marks;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.SetMarks(85);
        Console.WriteLine("Marks: " + s.GetMarks());
    }
}