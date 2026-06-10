namespace QueueAndStack.Examples;

public static class UsingQueueClass {
    public static void Run() {
        // First in, first out
        var queue = new Queue<string>();

        queue.Enqueue("Diego");
        queue.Enqueue("Amanda");
        queue.Enqueue("Eduarda");
        queue.Enqueue("Amora");
        queue.Enqueue("Ameixa");

        Console.WriteLine($"{string.Join(", ", queue)}\n");
        Console.WriteLine($"First element: {queue.Peek()}\n");

        while (queue.Count > 0) {
            Console.WriteLine(queue.Dequeue());
        }
    }
}