namespace Chapter004.Patterns;

public static class Example001 {
    public static void Run() {
        // The constant pattern lets you match directly to a constant, and is useful when working with the object type.

        object obj = 3;

        // if (obj is int && (int)obj == 3) Console.WriteLine("{0} => {1}", nameof(obj), obj);
        if (obj is 3) Console.WriteLine("{0} => {1}", nameof(obj), obj);
    }
}