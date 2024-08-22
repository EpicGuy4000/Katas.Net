using Katas.Net.GreedyAlgorithm;

namespace Katas.Net.Tests.GreedyAlgorithm;

public class RemovingMinimumAndMaximumFromArrayTests
{
    [TestCase(new [] {3, 2, 5, 1, 4}, 3)]
    [TestCase(new [] {7, 5, 6, 8, 1}, 2)]
    [TestCase(new [] {2, 4, 10, 1, 3, 5}, 4)]
    public void Run(int[] input, int expectedOutput)
    {
        var output = RemovingMinimumAndMaximumFromArray.CountOperationsRequired(input);
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}