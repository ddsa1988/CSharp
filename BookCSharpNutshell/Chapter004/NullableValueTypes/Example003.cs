namespace Chapter004.NullableValueTypes;

public static class Example003 {
    public static void Run() {
        // When T? is boxed, the boxed value on the heap contains T, not T?. This optimization
        // is possible because a boxed value is a reference type that can already express null.
    }
}