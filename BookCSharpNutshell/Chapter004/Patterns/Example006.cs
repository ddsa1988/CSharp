namespace Chapter004.Patterns;

public static class Example006 {
    public static void Run() {
        // List patterns (from C# 11) work with any collection type that is countable (with
        // a Count or Length property) and indexable (with an indexer of type int or System.Index).

        int[] numbers = [0, 1, 2, 3, 4];

        // A list pattern matches a series of elements in square brackets
        Console.WriteLine(numbers is [0, 1, 2, 3, 4]);

        // An underscore matches a single element of any value
        Console.WriteLine(numbers is [0, _, 2, 3, _]);

        // Two dots indicate a slice. A slice matches zero or more elements
        Console.WriteLine(numbers is [0, .., 4]);

        Console.WriteLine(numbers is [0, 1, >= 2, 3, 4]);
    }
}