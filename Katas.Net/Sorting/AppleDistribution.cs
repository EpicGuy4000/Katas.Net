namespace Katas.Net.Sorting;

public static class AppleDistribution
{
    public static int DistributeApples(int[] apples, int[] boxCapabilities)
    {
        ISortingAlgorithm sortingAlgorithm = new MergeSort();
        
        var sortedBoxes = sortingAlgorithm.Sort(boxCapabilities);
        var leftoverApples = apples.Sum();

        if (leftoverApples == 0) return 0;

        for (var i = sortedBoxes.Length - 1; i >= 0; i--)
        {
            leftoverApples -= sortedBoxes[i];

            if (leftoverApples <= 0) return sortedBoxes.Length - i;
        }
        
        return int.MaxValue;
    }
}