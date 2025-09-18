namespace Examples.Stack;

public static class Example001 {
    public static void Run() {
        var myStack = new Stack<string>();

        myStack.Push("First in line");
        myStack.Push("Second in line");
        myStack.Push("Third in line");
        myStack.Push("Fourth in line");

        Console.WriteLine($"Peek: {myStack.Peek()}");
        Console.WriteLine($"Count before pop: {myStack.Count}");

        while (myStack.Count > 0) {
            Console.WriteLine(myStack.Pop());
        }

        Console.WriteLine($"Count after dequeue: {myStack.Count}");
    }
}