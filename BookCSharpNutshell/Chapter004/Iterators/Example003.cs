namespace Chapter004.Iterators;

public static class Example003 {
    public static void Run() {
        // yield break

        foreach (string value in Foo(true)) {
            Console.Write(value + " ");
        }
    }

    private static IEnumerable<string> Foo(bool breakEarly) {
        yield return "One";
        yield return "Two";

        if (breakEarly) {
            yield break;
        }

        yield return "Three";
    }
}