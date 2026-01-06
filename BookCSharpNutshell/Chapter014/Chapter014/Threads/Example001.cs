namespace Chapter014.Threads;

public static class Example001 {
    // A thread is an execution path that can proceed independently of others.
    public static void Run() {
        var thread = new Thread(WriteY) {
            Name = "Thread WriteY"
        };

        thread.Start();

        WriteX();
    }

    private static void WriteX() {
        for (int i = 0; i < 100; i++) {
            Console.Write("x");
        }
    }

    private static void WriteY() {
        for (int i = 0; i < 100; i++) {
            Console.Write("y");
        }
    }
}