namespace Katas.Net;

public class InLineComparer<T>(Func<T, T, int> compareImplementation) : IComparer<T>
{
    public int Compare(T? x, T? y)
    {
        if (x == null && y == null) return 0;
        if (x == null && y != null) return -1;
        if (x != null && y == null) return 1;
        return compareImplementation(x!, y!);
    }
}