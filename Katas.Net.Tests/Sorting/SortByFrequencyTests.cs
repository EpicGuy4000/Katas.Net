using Katas.Net.Sorting;

namespace Katas.Net.Tests.Sorting;

public class SortByFrequencyTests
{
    [TestCase(new[] {4, 4, 6, 2, 2, 2}, new[] {6, 4, 4, 2, 2, 2})]
    [TestCase(new[] {0, -1, -1, -1, 5}, new[] {5, 0, -1, -1, -1})]
    [TestCase(new[] {10, 10, 10, 20, 20, 30}, new[] {30, 20, 20, 10, 10, 10})]
    public void Sort(int[] nums, int[] expectedOutput)
    {
        CollectionAssert.AreEqual(expectedOutput, SortByFrequency.Sort(nums));
    }
}