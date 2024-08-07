namespace Katas.Net.Sorting;

public static class TopKFrequentNumbers
{
    private static readonly ISortingAlgorithm SortingAlgorithm = new QuickSort();

    public static int[] FindTopK(int[] nums, int k)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            frequencyDictionary[num] = frequencyDictionary.GetValueOrDefault(num) + 1;
        }

        var sortedValues = SortingAlgorithm.SortBy(frequencyDictionary.Keys.ToArray(),
            new InLineComparer<int>((x, y) => frequencyDictionary[y] - frequencyDictionary[x]));

        return sortedValues[..k];
    }
}