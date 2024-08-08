namespace Katas.Net.GreedyAlgorithm;

public static class ValidPalindrome
{
    public static bool Check(string input)
    {
        var leftSkipCount = 1;

        var leftIndex = 0;
        var rightIndex = input.Length - 1;

        while (leftIndex < rightIndex)
        {
            if (input[leftIndex] == input[rightIndex])
            {
                leftIndex++;
                rightIndex--;
                continue;
            }

            if (leftSkipCount == 0) return false;
            if (input[leftIndex + 1] == input[rightIndex]) leftIndex++;
            else rightIndex--;
            leftSkipCount--;
        }

        return true;
    }
}