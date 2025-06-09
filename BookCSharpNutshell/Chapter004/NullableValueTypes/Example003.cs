namespace Chapter004.NullableValueTypes;

public static class Example003 {
    public static void Run() {
        // When T? is boxed, the boxed value on the heap contains T, not T?. This optimization
        // is possible because a boxed value is a reference type that can already express null.
        // C# also permits the unboxing of nullable value types with the as operator.
        // The result will be null if the cast fails.

        object o = "string";
        int? x = o as int?;
        
        Console.WriteLine(x.HasValue);
    }
}