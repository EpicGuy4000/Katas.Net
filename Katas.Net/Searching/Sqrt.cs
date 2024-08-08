namespace Katas.Net.Searching;

public static class Sqrt
{
    public static int Calculate(int x)
    {
        if (x == 0) return 0;
        if (x < 4) return 1;

        var lowEstimate = 2;
        var highEstimate = x / 2;

        while (lowEstimate <= highEstimate)
        {
            var midEstimate = (lowEstimate + highEstimate) / 2;
            int midEstimateSquared;
            try
            {
                checked
                {
                    midEstimateSquared = midEstimate * midEstimate;
                }
            }
            catch
            {
                highEstimate = midEstimate - 1;
                continue;
            }
            var comparisonResult = midEstimateSquared.CompareTo(x);
            if (comparisonResult == 0) return midEstimate;
            if (comparisonResult > 0) highEstimate = midEstimate - 1;
            else lowEstimate = midEstimate + 1;
        }

        return lowEstimate - 1;
    }
}