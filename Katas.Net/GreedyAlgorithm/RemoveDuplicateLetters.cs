namespace Katas.Net.GreedyAlgorithm;

public static class RemoveDuplicateLetters
{
    public static string Remove(string input)
    {
        var counter = new Dictionary<char, int>();

        foreach (var c in input)
        {
            counter[c] = counter.GetValueOrDefault(c) + 1;
        }

        var used = new List<char>(counter.Keys.Count);
        var unused = new HashSet<char>(counter.Keys);

        foreach (var c in input)
        {
            counter[c]--;

            if (!unused.Contains(c)) continue;
            
            while (used.Count > 0 && c < used[^1] && counter[used[^1]] > 0)
            {
                unused.Add(used[^1]);
                used.RemoveAt(used.Count - 1);
            }

            used.Add(c);
            unused.Remove(c);
        }
        
        return new string(used.ToArray());
    }
}