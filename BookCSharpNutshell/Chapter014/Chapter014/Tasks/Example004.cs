namespace Chapter014.Tasks;

public static class Example004 {
    // Returning value from Tasks
    public static void Run() {
        Task<int> task = Task.Run(() => {
            Console.WriteLine("Inside a task.");

            Task.Delay(2000).Wait();

            return 10;
        });

        int result = task.Result; // Block the current thread until the task finishes

        Console.WriteLine("Outside a task.");
        Console.WriteLine($"{nameof(result)} = {result}");
    }
}