namespace Chapter014.Tasks;

public static class Example001 {
    public static void Run() {
        Task.Run(() => Console.WriteLine("This is a task."));
        Console.ReadKey();
    }
}