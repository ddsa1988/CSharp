namespace Examples.Nullable;

public static class Example003 {
    // The null assign operator
    public static void Run() {
        Console.Write("Type something or press enter: ");
        string? input = Console.ReadLine();

        input ??= "You entered an invalid input";

        Console.WriteLine(input);
    }
}