namespace Chapter014.Tasks;

public static class Example002 {
    public static void Run() {
        Task task = Task.Run(() => {
            Console.WriteLine("Task is running...");
            Thread.Sleep(2000);
            Console.WriteLine("Task is finished.");
        });

        Console.WriteLine($"{nameof(task.IsCompleted)} = {task.IsCompleted}");

        task.Wait();

        Console.WriteLine($"{nameof(task.IsCompleted)} = {task.IsCompleted}");
    }
}