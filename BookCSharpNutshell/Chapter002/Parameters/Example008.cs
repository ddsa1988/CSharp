namespace Chapter002.Parameters;

public static class Example008 {
    public static void Run() {
        // Methods, constructors, and indexers can declare optional parameters.
        // A parameter is optional if it specifies a default value in its declaration.

        Console.WriteLine(Foo());
        Console.WriteLine(Foo(10));
    }

    private static int Foo(int a = 50) {
        return a;
    }
}