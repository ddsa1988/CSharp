namespace Chapter002.Parameters;

public static class Example002 {
    public static void Run() {
        // By default, arguments in C# are passed by value, which is by far the most common case.
        // This means that a copy of the value is created when passed to the method.

        const int x = 8;

        Console.WriteLine("Before method: {0} = {1}", nameof(x), x);

        Foo(x);

        Console.WriteLine("After method: {0} = {1}", nameof(x), x);
    }

    private static void Foo(int a) {
        a += 1;
        Console.WriteLine("Inside method: {0} = {1}", nameof(a), a);
    }
}