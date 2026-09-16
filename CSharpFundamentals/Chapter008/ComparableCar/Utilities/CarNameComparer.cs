using ComparableCar.Models;

namespace ComparableCar.Utilities;

internal class CarNameComparer : IComparer<Car> {
    public int Compare(Car? x, Car? y) {
        if (ReferenceEquals(x, y)) return 0;

        if (y is null) return 1;

        if (x is null) return -1;

        return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
    }
}