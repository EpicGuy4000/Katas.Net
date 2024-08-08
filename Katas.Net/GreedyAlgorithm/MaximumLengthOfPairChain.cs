namespace Katas.Net.GreedyAlgorithm;

public static class MaximumLengthOfPairChain
{
    public static int Find(int[][] pairChain)
    {
        var sorted = pairChain.OrderBy(pair => pair[1]).ToArray();

        var currentValue = sorted[0][0] - 1;
        var length = 0;

        foreach (var pair in sorted)
        {
            if (pair[0] <= currentValue) continue;
            length++;
            currentValue = pair[1];
        }

        return length;
    }
}