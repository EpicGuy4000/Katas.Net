using Katas.Net.Sorting;

namespace Katas.Net.Tests.Sorting;

public class EqualizerTests
{
    [TestCase(new[] {3, 5, 5, 2}, 5)]
    [TestCase(new[] {11, 9, 7, 5, 3}, 10)]
    [TestCase(new[] {8, 8, 8, 8}, 0)]
    public void Sort(int[] nums, int expectedOutput)
    {
        Assert.That(Equalizer.Equalize(nums), Is.EqualTo(expectedOutput));
    }
}