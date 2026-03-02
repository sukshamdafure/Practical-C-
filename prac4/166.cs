using Moq;

public interface IService
{
    int GetData();
}

class Program
{
    static void Main()
    {
        var mock = new Mock<IService>();
        mock.Setup(s => s.GetData()).Returns(10);

        Console.WriteLine(mock.Object.GetData());
    }
}