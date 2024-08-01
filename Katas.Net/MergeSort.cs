namespace Katas.Net;

public class MergeSort : ISortingAlgorithm
{
    private T[] Merge<T>(T[] left, T[] right, IComparer<T> comparer)
    {
        var sorted = new T[left.Length + right.Length];
        var leftIndex = 0;
        var rightIndex = 0;
        var sortedIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (comparer.Compare(left[leftIndex], right[rightIndex]) <= 0)
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
    
    private static void Swap<T>(T[] elements, int indexOne, int indexTwo) => 
        (elements[indexOne], elements[indexTwo]) = (elements[indexTwo], elements[indexOne]);

    public T[] SortBy<T>(T[] elements, IComparer<T> comparer)
    {
        switch (elements.Length)
        {
            case 1:
                return elements;
            case 2:
            {
                if (comparer.Compare(elements[0], elements[1]) > 0) Swap(elements, 0, 1);
                return elements;
            }
        }

        var left = new T[elements.Length / 2];
        var right = new T[elements.Length - left.Length];
        Array.Copy(elements, 0, left, 0, left.Length);
        Array.Copy(elements, left.Length, right, 0, right.Length);
        
        return Merge(SortBy(left, comparer), SortBy(right, comparer), comparer);
    }
}