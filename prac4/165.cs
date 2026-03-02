using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void TestAdd()
    {
        Assert.AreEqual(5, 2 + 3);
    }
}