namespace Katas.Net;

public static class MeetingRooms {
    private static readonly ISortingAlgorithm SortingAlgorithm = new QuickSort();
    
    public static int FindMinimumRequiredRooms((int From, int To)[] timeIntervals)
    {
        if (timeIntervals.Length == 0) return 0;
        
        var intervalsSortedByEndTime =
            SortingAlgorithm.SortBy(timeIntervals, 
                new InLineComparer<(int From, int To)>((x, y) => x.To - y.To));
        var intervalsSortedByStartTime =
            SortingAlgorithm.SortBy(timeIntervals, 
                new InLineComparer<(int From, int To)>((x, y) => x.From - y.From));

        var maxConcurrent = 0;
        var currentConcurrent = 0;
        
        var endIndex = 0;
        
        for (var i = 0; i < intervalsSortedByStartTime.Length; i++)
        {
            while (intervalsSortedByStartTime[i].From >= intervalsSortedByEndTime[endIndex].To)
            {
                currentConcurrent--;
                endIndex++;
            }

            currentConcurrent++;
            maxConcurrent = int.Max(currentConcurrent, maxConcurrent);
        }

        return maxConcurrent;
    }
}