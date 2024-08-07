namespace Katas.Net.Searching;

public static class MinimumCommonValue
{
    public static int Find(int[] nums1, int[] nums2)
    {
        int[] searchThroughArray, searchForArray;

        if (nums1.Length > nums2.Length)
        {
            searchForArray = nums2;
            searchThroughArray = nums1;
        }
        else
        {
            searchThroughArray = nums2;
            searchForArray = nums1;
        }

        var lastIndexOfLower = 0;
        
        foreach (var value in searchForArray)
        {
            var lowIndex = lastIndexOfLower;
            var highIndex = searchThroughArray.Length - 1;

            while (lowIndex <= highIndex)
            {
                var midIndex = lowIndex + (highIndex - lowIndex) / 2;

                var comparisonResult = searchThroughArray[midIndex].CompareTo(value);

                switch (comparisonResult)
                {
                    case > 0:
                        highIndex = midIndex - 1;
                        break;
                    case < 0:
                        lowIndex = midIndex + 1;
                        break;
                    default:
                        return value;
                }
            }

            lastIndexOfLower = lowIndex;
        }

        return -1;
    }
}