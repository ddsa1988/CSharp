namespace Chapter004.Delegates;

public static class Example004 {
    public static void UserMain() {
        /*
            All delegate instances have multicast capability. This means that a delegate instance
            can reference not just a single target method but also a list of target methods.
            The + and += operators combine delegate instances.
         */

        var t = new Transformer(Method1);
        t += Method2;

        t("Delegate multicast");
    }

    private delegate void Transformer(string msg);

    private static void Method1(string msg) {
        Console.WriteLine("Method 1: " + msg);
    }

    private static void Method2(string msg) {
        Console.WriteLine("Method 2: " + msg);
    }
}