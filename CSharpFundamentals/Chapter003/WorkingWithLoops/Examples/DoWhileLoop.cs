namespace WorkingWithLoops.Examples;

internal static class DoWhileLoop {
    internal static void Run() {
        const int counter = 0;

        do {
            Console.WriteLine("Counter inside \"do while loop\": " + counter);
        } while (counter < 0);

        while (counter < 0) {
            Console.WriteLine("Counter inside \"while loop\": " + counter);
        }
    }
}