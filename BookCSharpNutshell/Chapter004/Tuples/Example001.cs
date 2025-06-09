namespace Chapter004.Tuples;

public static class Example001 {
    public static void Run() {
        // The simplest way to create a tuple literal is to list the desired values in parentheses.
        // This creates a tuple with unnamed elements, which you refer to as Item1, Item2, and so on.
        // Tuples are value types, with mutable (read/write) elements

        var bob = ("Bob", 22);
        Console.WriteLine("{0}: {1}", nameof(bob), bob);
        Console.WriteLine("{0}: {1}", nameof(bob.Item1), bob.Item1);
        Console.WriteLine("{0}: {1}", nameof(bob.Item2), bob.Item2);
    }
}