using Katas.Net.Sorting;

namespace Katas.Net.Tests.Sorting;

public class SortVowelsInStringTests
{
    [TestCase("gamE", "gEma")]
    [TestCase("aEiOu", "EOaiu")]
    [TestCase("DesIgnGurUs", "DIsUgnGerus")]
    public void Sort(string input, string expectedOutput)
    {
        CollectionAssert.AreEqual(expectedOutput, SortVowelsInString.Sort(input));
    }
}