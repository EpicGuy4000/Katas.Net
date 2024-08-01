namespace Katas.Net.Tests;

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