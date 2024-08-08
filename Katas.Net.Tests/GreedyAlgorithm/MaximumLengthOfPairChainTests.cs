using Katas.Net.GreedyAlgorithm;

namespace Katas.Net.Tests.GreedyAlgorithm;

public class MaximumLengthOfPairChainTests
{
    [TestCase(2, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 2, 3 })]
    [TestCase(3, new[] { 5, 6 }, new[] { 1, 2 }, new[] { 8, 9 }, new[] { 2, 3 })]
    [TestCase(3, new[] { 7, 8 }, new[] { 5, 6 }, new[] { 1, 2 }, new[] { 3, 5 }, new[] { 4, 5 }, new [] { 2, 3 })]
    [TestCase(2, new[] { 10, 20 }, new[] { 1, 10 }, new[] { 3, 8 }, new[] { 4, 7 }, new[] { 5, 6 })]
    public void Run(int expectedOutput, params int[][] pairs)
    {
        var output = MaximumLengthOfPairChain.Find(pairs);
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}