namespace Katas.Net.Sorting;

public class QuickSort : ISortingAlgorithm
{
    public T[] SortBy<T>(T[] elements, IComparer<T> comparer)
    {
        var sorted = new T[elements.Length];
        Array.Copy(elements, sorted, elements.Length);
        
        SortInternal(sorted, comparer, 0, elements.Length - 1);

        return sorted;
    }

    private void SortInternal<T>(T[] elements, IComparer<T> comparer, int lowIndex, int highIndex)
    {
        if (lowIndex >= highIndex) return;
        var pivotIndex = Partition(elements, comparer, lowIndex, highIndex);
            
        SortInternal(elements, comparer, lowIndex, pivotIndex - 1);
        SortInternal(elements, comparer, pivotIndex, highIndex);
    }

    private int Partition<T>(T[] elements, IComparer<T> comparer, int lowIndex, int highIndex)
    {
        var pivotIndex = ChoosePivotIndex(elements, comparer, lowIndex, highIndex);
        var pivot = elements[pivotIndex];
        
        // Place pivot on end
        Swap(elements, pivotIndex, highIndex);

        var currentLowIndex = lowIndex - 1;

        for (var i = lowIndex; i < highIndex; i++)
        {
            if (comparer.Compare(elements[i], pivot) > 0) continue;

            // Place elements less than pivot at the start of range
            currentLowIndex++;
            Swap(elements, i, currentLowIndex);
        }

        // Place pivot after all elements less than it
        currentLowIndex++;
        Swap(elements, highIndex, currentLowIndex);

        return currentLowIndex;
    }

    private static int ChoosePivotIndex<T>(T[] elements, IComparer<T> comparer, int lowIndex, int highIndex)
    {
        if (highIndex - lowIndex == 1) return highIndex;
        
        var midIndex = lowIndex + (highIndex - lowIndex) / 2;
        if ((comparer.Compare(elements[midIndex], elements[lowIndex]) >= 0 &&
            comparer.Compare(elements[midIndex], elements[highIndex]) <= 0) ||
            (comparer.Compare(elements[midIndex], elements[lowIndex]) <= 0 &&
             comparer.Compare(elements[midIndex], elements[highIndex]) >= 0))
        {
            return midIndex;
        }

        if ((comparer.Compare(elements[lowIndex], elements[midIndex]) >= 0 &&
             comparer.Compare(elements[lowIndex], elements[highIndex]) <= 0) ||
            (comparer.Compare(elements[lowIndex], elements[midIndex]) <= 0 &&
             comparer.Compare(elements[lowIndex], elements[highIndex]) >= 0))
        {
            return lowIndex;
        }

        return highIndex;
    }

    private static void Swap<T>(T[] elements, int indexOne, int indexTwo) => 
        (elements[indexOne], elements[indexTwo]) = (elements[indexTwo], elements[indexOne]);
}