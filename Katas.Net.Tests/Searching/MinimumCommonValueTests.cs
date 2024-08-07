using Katas.Net.Searching;

namespace Katas.Net.Tests.Searching;

public class MinimumCommonValueTests
{
    [TestCase(new[] {1, 3, 5, 7}, new[] {3, 4, 5, 6, 8, 10}, 3)]
    [TestCase(new[] {2, 4, 6}, new[] { 1, 3, 5 }, -1)]
    [TestCase(new[] {1, 2, 2, 3}, new[] { 2, 2, 4 }, 2)]
    public void Run(int[] nums1, int[] nums2, int expectedOutput)
    {
        var output = MinimumCommonValue.Find(nums1, nums2);
        
        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}