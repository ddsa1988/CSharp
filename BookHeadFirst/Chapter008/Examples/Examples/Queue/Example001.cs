namespace Examples.Queue;

public static class Example001 {
    public static void Run() {
        var myQueue = new Queue<string>();

        myQueue.Enqueue("First in line");
        myQueue.Enqueue("Second in line");
        myQueue.Enqueue("Third in line");
        myQueue.Enqueue("Fourth in line");

        Console.WriteLine($"Peek: {myQueue.Peek()}");
        Console.WriteLine($"Count before dequeue: {myQueue.Count}");

        while (myQueue.Count > 0) {
            Console.WriteLine(myQueue.Dequeue());
        }

        Console.WriteLine($"Count after dequeue: {myQueue.Count}");
    }
}