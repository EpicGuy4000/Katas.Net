using Katas.Net.GreedyAlgorithm;

namespace Katas.Net.Tests.GreedyAlgorithm;

public class RemoveDuplicateLettersTests
{
    [TestCase("bbaac", "bac")]
    [TestCase("zabccdef", "zabcdef")]
    [TestCase("mnopmn", "mnop")]
    public void Run(string input, string expectedOutput)
    {
        var output = RemoveDuplicateLetters.Remove(input);
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}