var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/upload", async (IFormFile file) =>
{
    var path = Path.Combine("uploads", file.FileName);
    Directory.CreateDirectory("uploads");

    using var stream = File.Create(path);
    await file.CopyToAsync(stream);

    return Results.Ok("File Uploaded");
});

app.MapGet("/download/{filename}", (string filename) =>
{
    var path = Path.Combine("uploads", filename);
    return Results.File(path, "application/octet-stream", filename);
});

app.Run();