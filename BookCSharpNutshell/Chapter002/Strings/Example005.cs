namespace Chapter002.Strings;

public static class Example005 {
    public static void UserMain() {
        // Verbatim string literal is prefixed with @ and does not support escape sequences.

        const string a = "\\\\\\\\server\\\\file-share\\\\hello-world.cs"; // String with escape sequence
        const string b = @"\\\\server\\file-share\\hello-world.cs"; // Verbatim string literal

        Console.WriteLine("{0} = {1}", nameof(a), a);
        Console.WriteLine("{0} = {1}", nameof(b), b);
    }
}