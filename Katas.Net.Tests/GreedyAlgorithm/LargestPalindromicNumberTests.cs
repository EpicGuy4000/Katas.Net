using Katas.Net.GreedyAlgorithm;

namespace Katas.Net.Tests.GreedyAlgorithm;

public class LargestPalindromicNumberTests
{
    [TestCase("323211444", "432141234")]
    [TestCase("998877", "987789")]
    [TestCase("54321", "5")]
    [TestCase("0000000", "0")]
    public void Run(string input, string expectedOutput)
    {
        var output = LargestPalindromicNumber.Find(input);
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}