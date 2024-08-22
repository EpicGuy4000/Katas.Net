namespace Katas.Net.GreedyAlgorithm;

public static class RemovingMinimumAndMaximumFromArray
{
    public static int CountOperationsRequired(int[] array)
    {
        if (array.Length < 3) return array.Length;
        
        var indexOfMin = 0;
        var indexOfMax = 0;

        for (var i = 1; i < array.Length; i++)
        {
            if (array[i] > array[indexOfMax]) indexOfMax = i;
            if (array[i] < array[indexOfMin]) indexOfMin = i;
        }
        
        var indicesToRemove = new[] { indexOfMin, indexOfMax };
        
        var currentLeft = -1;
        var currentRight = array.Length;

        var operations = 0;

        foreach (var index in indicesToRemove)
        {
            if (currentLeft >= index || currentRight <= index) continue;

            if (index - currentLeft < currentRight - index)
            {
                operations += index - currentLeft;
                currentLeft = index;
            }
            else
            {
                operations += currentRight - index;
                currentRight = index;
            }
        }

        return operations;
    }
}