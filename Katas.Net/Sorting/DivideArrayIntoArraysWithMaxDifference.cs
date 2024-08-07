namespace Katas.Net.Sorting;

public static class DivideArrayIntoArraysWithMaxDifference
{
    public static int[][] Divide(int[] nums, int k)
    {
        if (nums.Length % 3 != 0) return [];
        
        ISortingAlgorithm sortingAlgorithm = new MergeSort();

        var sortedArray = sortingAlgorithm.Sort(nums);

        var dividedArrays = new int[nums.Length / 3][];

        for (var i = 0; i < sortedArray.Length - 2; i += 3)
        {
            if (sortedArray[i + 2] - sortedArray[i] > k) return [];

            dividedArrays[i / 3] = sortedArray[i..(i + 3)];
        }

        return dividedArrays;
    }
}