namespace Katas.Net;

public static class SortByFrequency
{
    public static int[] Sort(int[] nums)
    {
        var counter = new Dictionary<int, int>();

        foreach (var num in nums)
            counter[num] = counter.GetValueOrDefault(num) + 1;

        return new MergeSort().SortBy(nums, new InLineComparer<int>((x, y) =>
        {
            var comparisonResult = counter[x] - counter[y];
            if (comparisonResult != 0) return comparisonResult;
            return y - x;
        }));
    }
}