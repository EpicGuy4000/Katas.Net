namespace Katas.Net.GreedyAlgorithm;

public static class AddToMakeParenthesesValid
{
    public static int CountNeededActions(string input)
    {
        var openingBracesAdded = 0;
        var currentlyOpen = 0;

        foreach (var brace in input)
        {
            if (brace == '(') currentlyOpen++;
            else currentlyOpen--;

            if (currentlyOpen == -1)
            {
                openingBracesAdded += 1;
                currentlyOpen = 0;
            }
        }

        return openingBracesAdded + currentlyOpen;
    }
}