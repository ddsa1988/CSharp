namespace Multithreading.Examples;

internal static class ThreadStatus {
    public static void Run() {
        Console.WriteLine("***** Primary Thread Status *****\n");

        var primaryThread = Thread.CurrentThread;
        primaryThread.Name = "ThePrimaryThread";

        Console.WriteLine("ID of current thread: " + primaryThread.ManagedThreadId);
        Console.WriteLine("Thread name: " + primaryThread.Name);
        Console.WriteLine("Has thread started: " + primaryThread.IsAlive);
        Console.WriteLine("Priority level: " + primaryThread.Priority);
        Console.WriteLine("Thread state: " + primaryThread.ThreadState);
    }
}