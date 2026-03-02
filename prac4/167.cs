using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        var response = await client.GetStringAsync("https://api.github.com");
        Console.WriteLine(response);
    }
}