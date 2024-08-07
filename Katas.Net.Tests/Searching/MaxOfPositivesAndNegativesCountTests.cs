using Katas.Net.Searching;

namespace Katas.Net.Tests.Searching;

public class MaxOfPositivesAndNegativesCountTests
{
    [TestCase(new[] {-4, -3, -1, 0, 1, 3, 5, 7}, 4)]
    [TestCase(new[] {-8, -7, -5, -4, 0, 0, 0}, 4)]
    [TestCase(new[] {0, 2, 2, 3, 3, 3, 4}, 6)]
    public void Run(int[] nums, int expectedOutput)
    {
        var output = MaxOfPositivesAndNegativesCount.Find(nums);
        
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}