// Install Microsoft.EntityFrameworkCore package first

using System;
using Microsoft.EntityFrameworkCore;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("your_connection_string_here");
}

class Program
{
    static void Main()
    {
        using var db = new AppDbContext();
        db.Students.Add(new Student { Name = "Suksham" });
        db.SaveChanges();
    }
}