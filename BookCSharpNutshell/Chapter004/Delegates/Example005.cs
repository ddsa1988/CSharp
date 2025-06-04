namespace Chapter004.Delegates;

public static class Example005 {
    public static void Run() {
        // Multicast delegate example

        var p = new ProgressReporter(WriteProgressToConsole);
        p += WriteProgressToFile;

        HardWork(p);
    }

    private delegate void ProgressReporter(int percentComplete);

    private static void HardWork(ProgressReporter progress) {
        for (int i = 0; i < 10; i++) {
            progress(i * 10);
            Thread.Sleep(500);
        }
    }

    public static void WriteProgressToConsole(int percentComplete) {
        Console.WriteLine("Write on console: " + percentComplete);
    }

    public static void WriteProgressToFile(int percentComplete) {
        Console.WriteLine("Write on file: " + percentComplete);
    }
}