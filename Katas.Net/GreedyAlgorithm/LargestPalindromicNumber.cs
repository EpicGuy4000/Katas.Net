using System.Text;

namespace Katas.Net.GreedyAlgorithm;

public static class LargestPalindromicNumber
{
    public static string Find(string input)
    {
        var counter = new Dictionary<char, int>();
        foreach (var c in input)
        {
            counter[c] = counter.GetValueOrDefault(c) + 1;
        }

        var sortedKeys = counter.Keys.ToArray();
        
        Array.Sort(sortedKeys);

        char? middle = null;

        var builder = new StringBuilder();

        foreach (var c in sortedKeys.Reverse())
        {
            if (c == '0') continue;

            middle = AppendLetter(c, builder, counter, middle);
        }

        if (builder.Length > 1 && counter.ContainsKey('0'))
        {
            middle = AppendLetter('0', builder, counter, middle);
        }

        var end = new string(builder.ToString().Reverse().ToArray());

        if (middle != null)
        {
            builder.Append(middle);
        }

        builder.Append(end);

        if (builder.Length == 0) builder.Append(sortedKeys.Last());

        return builder.ToString();
    }

    private static char? AppendLetter(char c, StringBuilder builder, Dictionary<char, int> counter, char? currentMiddle)
    {
        builder.Append(c, counter[c] / 2);

        if (currentMiddle == null && counter[c] % 2 != 0)
        {
            currentMiddle = c;
        }

        return currentMiddle;
    }
}