namespace Ducks.Models;

public class Duck : IComparable<Duck> {
    public KindOfDuck Kind { get; init; }
    public int Size { get; init; }

    public int CompareTo(Duck? other) {
        if (ReferenceEquals(this, other)) return 0;

        if (other is null) return 1;

        if (Size > other.Size) return 1;

        if (Size < other.Size) return -1;

        return 0;
    }
}