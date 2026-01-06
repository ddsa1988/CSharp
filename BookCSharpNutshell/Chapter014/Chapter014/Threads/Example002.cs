namespace Chapter014.Threads;

public static class Example002 {
    public static void Run() {
        /*
         * You can wait for another thread to end by calling its Join method.
         * You can include a timeout when calling Join, either in milliseconds or as a TimeSpan.
         * It then returns true if the thread ended or false if it timed out.
         */
        var tread = new Thread(WriteY) {
            Name = "Thread WriteY",
        };

        tread.Start();
        tread.Join(TimeSpan.FromSeconds(5));

        Console.WriteLine("\nThread has ended.");
    }

    private static void WriteY() {
        for (int i = 0; i < 100; i++) {
            Console.Write("y");
        }
    }
}