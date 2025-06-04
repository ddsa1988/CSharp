namespace Chapter004.Exceptions;

public static class Example003 {
    public static void Run() {
        // Throwing Exceptions

        try {
            Display("Hello.");
            Display(null);
        } catch (Exception e) {
            Console.WriteLine("Exception: {0}", e.Message);
        }
    }

    private static void Display(string? msg) {
        if (string.IsNullOrEmpty(msg) || string.IsNullOrWhiteSpace(msg)) {
            throw new ArgumentException($"Argument '{nameof(msg)}' must not be null or empty.");
        }

        Console.WriteLine(msg);
    }
}