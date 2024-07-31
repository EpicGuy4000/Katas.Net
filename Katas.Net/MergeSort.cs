namespace Katas.Net;

public class MergeSort : ISortingAlgorithm
{
    public int[] Sort(int[] elements)
    {
        switch (elements.Length)
        {
            case 1:
                return elements;
            case 2:
            {
                if (elements[0] > elements[1]) Swap(elements, 0, 1);
                return elements;
            }
        }

        var left = new int[elements.Length / 2];
        var right = new int[elements.Length - left.Length];
        Array.Copy(elements, 0, left, 0, left.Length);
        Array.Copy(elements, left.Length, right, 0, right.Length);
        
        return Merge(Sort(left), Sort(right));
    }

    private int[] Merge(int[] left, int[] right)
    {
        var sorted = new int[left.Length + right.Length];
        var leftIndex = 0;
        var rightIndex = 0;
        var sortedIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
            {
                sorted[sortedIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                sorted[sortedIndex] = right[rightIndex];
                rightIndex++;
            }

            sortedIndex++;
        }

        while (leftIndex < left.Length)
        {
            sorted[sortedIndex] = left[leftIndex];
            leftIndex++;
            sortedIndex++;
        }

        while (rightIndex < right.Length)
        {
            sorted[sortedIndex] = right[rightIndex];
            rightIndex++;
            sortedIndex++;
        }

        return sorted;
    }
    
    private static void Swap(int[] elements, int indexOne, int indexTwo)
    {
        elements[indexOne] ^= elements[indexTwo];
        elements[indexTwo] ^= elements[indexOne];
        elements[indexOne] ^= elements[indexTwo];
    }
}