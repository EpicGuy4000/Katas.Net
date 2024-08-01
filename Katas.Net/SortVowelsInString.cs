using System.Collections.Frozen;
using System.Text;

namespace Katas.Net;

public static class SortVowelsInString
{
    private static readonly FrozenSet<char> Vowels = "aeiouAEIOU".ToFrozenSet();
    private static bool IsVowel(char c) => Vowels.Contains(c);
    
    public static string Sort(string input)
    {
        ISortingAlgorithm sortingAlgorithm = new MergeSort();
        var vowelsInInput = input.Where(IsVowel).ToArray();

        var vowelsIndex = 0;
        var inputIndex = 0;

        var sortedVowels = sortingAlgorithm.Sort(vowelsInInput);

        var stringBuilder = new StringBuilder();
        
        while (inputIndex < input.Length)
        {
            if (IsVowel(input[inputIndex]))
            {
                stringBuilder.Append(sortedVowels[vowelsIndex]);
                vowelsIndex++;
            }
            else
            {
                stringBuilder.Append(input[inputIndex]);
            }

            inputIndex++;
        }

        return stringBuilder.ToString();
    }
}