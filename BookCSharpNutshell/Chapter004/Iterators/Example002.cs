namespace Chapter004.Iterators;

public static class Example002 {
    public static void Run() {
        // Multiple yield statements

        foreach (string value in Foo()) {
            Console.Write(value + " ");
        }
    }

    private static IEnumerable<string> Foo() {
        yield return "One";
        yield return "Two";
        yield return "Three";
    }
}