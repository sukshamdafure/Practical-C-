using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("TestDb"));

var app = builder.Build();

app.MapGet("/students", async (AppDbContext db) =>
    await db.Students.ToListAsync());

app.MapPost("/students", async (AppDbContext db, Student student) =>
{
    db.Students.Add(student);
    await db.SaveChangesAsync();
    return Results.Ok(student);
});

app.Run();

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Student> Students => Set<Student>();
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}