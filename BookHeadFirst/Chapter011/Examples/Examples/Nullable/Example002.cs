namespace Examples.Nullable;

public static class Example002 {
    // The null-coalescing operator
    public static void Run() {
        Console.Write("Type something or press enter: ");
        string? input = Console.ReadLine();

        string msg = input ?? "You entered an invalid input";

        Console.WriteLine(msg);
    }
}