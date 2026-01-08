namespace Chapter014.Threads;

public static class Example005 {
    /*
     * When two threads simultaneously contend a lock (which can be upon any
     * reference-type object; in this case, locker), one thread waits, or blocks,
     * until the lock becomes available.
     */

    private static readonly object Locker = new();

    public static void Run() {
        int value = 0;

        var thread1 = new Thread(() => MyMethod(ref value, 100, "Thread 1"));
        var thread2 = new Thread(() => MyMethod(ref value, 200, "Thread 2"));

        Console.WriteLine("Starting...");

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Finished.");
    }

    private static void MyMethod(ref int value, int newValue, string msg) {
        Console.WriteLine("MyMethod: {0}", msg);

        lock (Locker) {
            Console.WriteLine($"Old value: {value}");
            value = newValue;
            Console.WriteLine($"New value: {value}");
        }
    }
}