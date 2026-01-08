namespace Chapter014.Threads;

public static class Example004 {
    /*
     * Two threads writing the same variable without thread safety.
     */

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

        Console.WriteLine($"Old value: {value}");
        value = newValue;
        Console.WriteLine($"New value: {value}");
    }
}