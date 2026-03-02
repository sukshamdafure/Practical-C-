public class Calculator
{
    public int Add(int a, int b) => a + b;
}

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }
}