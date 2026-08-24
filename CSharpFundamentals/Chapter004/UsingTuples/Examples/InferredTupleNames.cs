namespace UsingTuples.Examples;

internal static class InferredTupleNames {
    public static void Run() {
        Console.WriteLine("=> Inferred Tuple names:\n");

        var foo = new { Prop1 = "first", Prop2 = "second" };

        (string Prop1, string Prop2) bar = (foo.Prop1, foo.Prop2);

        Console.WriteLine($"{bar.Prop1}, {bar.Prop2}");
    }
}