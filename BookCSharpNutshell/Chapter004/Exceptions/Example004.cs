namespace Chapter004.Exceptions;

public static class Example004 {
    public static void Run() {
        // Rethrowing an exception
        
        try {
            Display("Hello.");
            Display(null);
        } catch (Exception e) {
            // Console.WriteLine("Exception: {0}", e);
            throw;
        }
    }
    
    private static void Display(string? msg) {
        if (string.IsNullOrEmpty(msg) || string.IsNullOrWhiteSpace(msg)) {
            throw new ArgumentException($"Argument '{nameof(msg)}' must not be null or empty.");
        }

        Console.WriteLine(msg);
    }
}