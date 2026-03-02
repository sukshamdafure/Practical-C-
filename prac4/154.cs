using System;

class Employee
{
    public string Name;
    public double BasicSalary;

    public double CalculateSalary()
    {
        double hra = BasicSalary * 0.2;
        double da = BasicSalary * 0.1;
        return BasicSalary + hra + da;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee { Name = "Suksham", BasicSalary = 20000 };
        Console.WriteLine("Total Salary: " + emp.CalculateSalary());
    }
}