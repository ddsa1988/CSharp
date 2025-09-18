namespace Examples.Lists.Models;

public enum KindOfDuck {
    Mallard,
    Muscovy,
    Loon,
}

public class Duck : Bird, IComparable<Duck> {
    private readonly int _size;
    public KindOfDuck Kind { get; init; }

    public int Size {
        get => _size;
        init => _size = value > 0 ? value : 1;
    }

    public int CompareTo(Duck? other) {
        if (other == null) return 0;

        if (Size > other.Size) return 1;

        if (Size < other.Size) return -1;

        if (Kind > other.Kind) return 1;

        if (Kind < other.Kind) return -1;

        return 0;
    }

    public override string ToString() {
        return $"Duck [Name = {Name}, Kind = {Kind}, Size = {Size}]";
    }
}

public class DuckComparer : IComparer<Duck> {
    public int Compare(Duck? x, Duck? y) {
        if (x == null || y == null) return 0;

        if (x.Size > y.Size) return 1;

        if (x.Size < y.Size) return -1;

        if (x.Kind > y.Kind) return 1;

        if (x.Kind < y.Kind) return -1;

        return 0;
    }
}