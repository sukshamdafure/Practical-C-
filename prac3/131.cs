using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new { Id = 1, Name = "Suksham" },
            new { Id = 2, Name = "Rahul" }
        };

        var marks = new[]
        {
            new { Id = 1, Score = 90 },
            new { Id = 2, Score = 85 }
        };

        var result = students.Join(
            marks,
            s => s.Id,
            m => m.Id,
            (s, m) => new { s.Name, m.Score });

        foreach (var item in result)
        {
            Console.WriteLine(item.Name + " - " + item.Score);
        }
    }
}