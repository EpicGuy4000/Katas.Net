namespace Katas.Net.Tests;

public class AppleDistributionTests
{
    [TestCase(new[] {2, 3, 1}, new[] {4, 2, 5, 1}, 2)]
    [TestCase(new[] {4, 5, 6}, new[] {5, 10}, 2)]
    [TestCase(new[] {1, 2, 5, 6}, new[] {2, 3, 7, 4, 5, 2, 4}, 3)]
    public void DistributeApples(int[] apples, int[] capacity, int expectedOutput)
    {
        Assert.That(AppleDistribution.DistributeApples(apples, capacity), Is.EqualTo(expectedOutput));
    }
}