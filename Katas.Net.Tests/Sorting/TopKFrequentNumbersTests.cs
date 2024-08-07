using Katas.Net.Sorting;

namespace Katas.Net.Tests.Sorting;

public class TopKFrequentNumbersTests
{
    [TestCase(new[] {1, 3, 5, 12, 11, 12, 11}, 2, new[] {12, 11})]
    [TestCase(new[] {5, 12, 11, 3, 11}, 2, new[] { 11, 5 }, new[] {12, 11}, new[] { 11, 3})]
    public void Sort(int[] nums, int k, params int[][] expectedOutputs)
    {
        var output = TopKFrequentNumbers.FindTopK(nums, k);

        var constraint = Is.EquivalentTo(expectedOutputs[0]);

        for (var i = 1; i < expectedOutputs.Length; i++)
        {
            constraint = constraint.Or.EquivalentTo(expectedOutputs[i]);
        }
        
        Assert.That(output, constraint);
    }
}