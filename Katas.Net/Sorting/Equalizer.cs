namespace Katas.Net.Sorting;

public static class Equalizer
{
    public static int Equalize(int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        ISortingAlgorithm sortingAlgorithm = new QuickSort();

        var sortedNums = sortingAlgorithm.Sort(nums);
        var minElement = sortedNums[0];
        var index = sortedNums.Length - 1;
        var lastElement = sortedNums[^1];
        var actionCounter = 0;

        while (sortedNums[index] != minElement)
        {
            if (sortedNums[index] != lastElement)
            {
                actionCounter += sortedNums.Length - index - 1;
                lastElement = sortedNums[index];
            }

            actionCounter++;
            index--;
        }

        return actionCounter;
    }
}