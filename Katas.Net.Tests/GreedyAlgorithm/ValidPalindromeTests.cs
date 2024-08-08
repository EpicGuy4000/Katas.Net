using Katas.Net.GreedyAlgorithm;

namespace Katas.Net.Tests.GreedyAlgorithm;

public class ValidPalindromeTests
{
    [TestCase("racecar", true)]
    [TestCase("abccdba", true)]
    [TestCase("abcdef", false)]
    public void Run(string input, bool expectedOutput)
    {
        var output = ValidPalindrome.Check(input);
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}