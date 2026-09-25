namespace Collections.Models;

internal class SortPeopleByAge : IComparer<Person> {
    public int Compare(Person? x, Person? y) {
        if (ReferenceEquals(x, y)) return 0;

        if (y is null) return 1;

        if (x is null) return -1;

        return x.Age.CompareTo(y.Age);
    }
}