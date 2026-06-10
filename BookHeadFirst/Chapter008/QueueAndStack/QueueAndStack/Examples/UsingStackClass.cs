namespace QueueAndStack.Examples;

public static class UsingStackClass {
    public static void Run() {
        // First in, last out
        var stack = new Stack<string>();

        stack.Push("Diego");
        stack.Push("Amanda");
        stack.Push("Eduarda");
        stack.Push("Amora");
        stack.Push("Ameixa");

        Console.WriteLine($"{string.Join(", ", stack)}\n");

        Console.WriteLine($"First element: {stack.Peek()}\n");

        while (stack.Count > 0) {
            Console.WriteLine(stack.Pop());
        }
    }
}