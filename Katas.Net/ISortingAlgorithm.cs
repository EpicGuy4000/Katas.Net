namespace Katas.Net;

public interface ISortingAlgorithm
{
    T[] Sort<T>(T[] elements) where T: IComparable => SortBy(elements, new InLineComparer<T>((x, y) => x.CompareTo(y)));
    T[] SortBy<T>(T[] elements, IComparer<T> comparer);
}