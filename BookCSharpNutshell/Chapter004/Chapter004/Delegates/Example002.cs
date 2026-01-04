namespace Chapter004.Delegates;

public static class Example002 {
    /*
     * All delegate instances have multicast capability. This means that a delegate instance
     * can reference not just a single target method but also a list of target methods.
     * The + and += operators combine delegate instances
     */
    public static void Run() {
        int myNumber = 0;

        Transformer transformer = Method1;
        transformer += Method2;

        transformer(ref myNumber);

        Console.WriteLine($"{nameof(myNumber)}: {myNumber}");
    }

    private delegate void Transformer(ref int x);

    private static void Method1(ref int x) => x += 10;
    private static void Method2(ref int x) => x *= 2;
}