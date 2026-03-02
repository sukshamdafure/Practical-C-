var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = 500;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync("{\"error\":\"Something went wrong\"}");
    });
});

app.MapGet("/", () => "Hello World");

app.MapGet("/error", () =>
{
    throw new Exception("Test Exception");
});

app.Run();