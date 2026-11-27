using Multithreading.Models;

namespace Multithreading.Examples;

internal static class SimpleMultiThreadApp {
    public static void Run() {
        Console.WriteLine("***** The Amazing Thread App *****\n");

        Console.Write("Do you want [1] or [2] threads? ");
        string? userInput = Console.ReadLine()?.ToLowerInvariant();

        // Name the current thread.
        var primaryThread = Thread.CurrentThread;
        primaryThread.Name = "Primary";

        // Display thread info.
        Console.WriteLine($"\n-> {primaryThread.Name} is executing {nameof(Run)}()");

        // Make worker class
        var printer = new Printer();

        switch (userInput) {
            case "1":
                break;
            case "2":
                break;
            default:
                Console.WriteLine("\nI don't know what you want...you get 1 thread.");
                goto case "1";
        }
    }
}