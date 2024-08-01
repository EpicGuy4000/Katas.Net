namespace Katas.Net;

public static class MaxOfPositivesAndNegativesCount
{
    public static int Find(int[] nums) => int.Max(CountNegatives(nums), CountPositives(nums));

    private static int CountPositives(int[] nums)
    {
        var lowIndex = 0;
        var highIndex = nums.Length - 1;

        while (lowIndex <= highIndex)
        {
            var mid = lowIndex + (highIndex - lowIndex) / 2;
            
            if (nums[mid] <= 0)
                lowIndex = mid + 1;
            else
                highIndex = mid - 1;
        }

        return nums.Length - lowIndex;
    }

    private static int CountNegatives(int[] nums)
    {
        var lowIndex = 0;
        var highIndex = nums.Length - 1;

        while (lowIndex <= highIndex)
        {
            var mid = lowIndex + (highIndex - lowIndex) / 2;
            
            if (nums[mid] >= 0)
                highIndex = mid - 1;
            else
                lowIndex = mid + 1;
        }

        return lowIndex;
    }
}