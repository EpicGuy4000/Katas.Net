using Katas.Net.GreedyAlgorithm;

namespace Katas.Net.Tests.GreedyAlgorithm;

public class AddToMakeParenthesesValidTests
{
    [TestCase("(()", 1)]
    [TestCase("))((", 4)]
    [TestCase("(()())(", 1)]
    public void Run(string input, int expectedOutput)
    {
        var output = AddToMakeParenthesesValid.CountNeededActions(input);
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}