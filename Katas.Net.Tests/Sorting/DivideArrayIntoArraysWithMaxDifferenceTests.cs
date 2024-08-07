using Katas.Net.Sorting;

namespace Katas.Net.Tests.Sorting;

public class DivideArrayIntoArraysWithMaxDifferenceTests
{
    [TestCase(new[] { 2, 6, 4, 9, 3, 7, 3, 4, 1 }, 3, new[] { 1, 2, 3 }, new[] { 3, 4, 4 }, new[] { 6, 7, 9 })]
    [TestCase(new[] { 10, 12, 15, 20, 25, 30 }, 10, new[] { 10, 12, 15 }, new[] { 20, 25, 30 })]
    [TestCase(new[] { 1, 2, 4, 5, 9, 10 }, 1)]
    public void Sort(int[] nums, int k, params int[][] expectedOutput)
    {
        var output = DivideArrayIntoArraysWithMaxDifference.Divide(nums, k);
        Assert.That(output, Has.Length.EqualTo(expectedOutput.Length));
        for (var i = 0; i < output.Length; i++)
        {
            CollectionAssert.AreEqual(expectedOutput[i], output[i]);
        }
    }
}