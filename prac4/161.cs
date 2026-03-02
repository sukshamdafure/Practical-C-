using Serilog;

class Program
{
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log.txt")
            .CreateLogger();

        Log.Information("Application Started");
        Log.Error("This is an error message");

        Log.CloseAndFlush();
    }
}