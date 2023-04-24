using TestDateFormat;
using NUnit.Framework;

namespace Library.Tests
{
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void TestDateCorrect()
    {
        const string input = "10/09/1997";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
    public void TestDateEmpty()
    {
        const string input = "";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    public void TestDateWrongYear()
    {
        const string input = "10/09/199";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
}