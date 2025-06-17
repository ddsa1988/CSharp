namespace Chapter004.Records;

public static class Example007 {
    public static void Run() {
        /*
            Two records are equal if their fields (and automatic properties) are equal.
            The default equality implementation for records is unavoidably fragile. In particular,
            it breaks if the record contains lazy values, transient values, arrays, or collection types.
        */

        var p1 = new Point(10, 20);
        var p2 = new Point(10, 20);

        Console.WriteLine("{0}.Equals({1}) => {2} ", nameof(p1), nameof(p2), p1.Equals(p2));
        Console.WriteLine("{0} == {1} => {2} ", nameof(p1), nameof(p2), p1 == p2);
    }

    private record Point(int X, int Y);
}