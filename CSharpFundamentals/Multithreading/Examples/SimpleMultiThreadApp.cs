namespace Multithreading.Examples;

internal static class SimpleMultiThreadApp {
    public static void Run() {
        Console.WriteLine("***** The Amazing Thread App *****\n");

        Console.Write("Do you want [1] or [2] threads? ");
        string? userInput = Console.ReadLine()?.ToLowerInvariant();

        if (userInput != "1" && userInput != "2") return;

        // Name the current thread.
        var primaryThread = Thread.CurrentThread;
        primaryThread.Name = "Primary";

        // Display thread info.
        Console.WriteLine($"\n-> {primaryThread.Name} is executing {nameof(Run)}()");
    }
}