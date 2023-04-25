namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        string date = "12/03/2004";
        string expected = "12-03-2004";

        string actual = DateFormatter.ChangeFormat(date);

        Assert.AreEqual(expected, actual);
    }

     [Test]
    public void IncorrectFormat()
    {
        string date = "12/03/2000004";
        string expected = "";

        string actual = DateFormatter.ChangeFormat(date);

        Assert.AreEqual(expected, actual);

    }

     [Test]
    public void BlankDate()
    {
        string date = "";
        string expected = "";

        string actual = DateFormatter.ChangeFormat(date);

        Assert.AreEqual(expected, actual);
    }
}