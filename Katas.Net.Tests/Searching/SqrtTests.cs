using Katas.Net.Searching;

namespace Katas.Net.Tests.Searching;

public class SqrtTests
{
    [TestCase(8, 2)]
    [TestCase(4, 2)]
    [TestCase(2, 1)]
    [TestCase(27, 5)]
    [TestCase(2147395600, 46340)]
    public void Run(int input, int expectedOutput)
    {
        var output = Sqrt.Calculate(input);
        
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}