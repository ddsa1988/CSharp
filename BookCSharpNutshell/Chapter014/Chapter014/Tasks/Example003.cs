namespace Chapter014.Tasks;

public static class Example003 {
    // Long-running tasks
    public static void Run() {
        Task task = Task.Factory.StartNew(() => {
            Console.WriteLine("This is long-running task.");

            for (int i = 0; i < 100; i++) {
                Console.Write(i + " ");
            }
        }, TaskCreationOptions.LongRunning);

        task.Wait();
    }
}