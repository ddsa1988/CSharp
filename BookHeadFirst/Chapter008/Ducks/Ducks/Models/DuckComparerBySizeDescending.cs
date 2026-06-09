namespace Ducks.Models;

public class DuckComparerBySizeDescending : IComparer<Duck> {
    public int Compare(Duck? x, Duck? y) {
        if (ReferenceEquals(x, y)) return 0;

        if (x is null) return -1;

        if (y is null) return 1;

        if (x.Size > y.Size) return -1;

        if (x.Size < y.Size) return 1;

        return 0;
    }
}