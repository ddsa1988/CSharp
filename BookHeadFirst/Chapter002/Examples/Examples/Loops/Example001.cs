namespace Examples.Loops;

public static class Example001 {
    public static void Run() {
        WhileLoop();

        Console.Write('\n');

        DoWhileLoop();

        Console.Write('\n');

        ForLoop();
    }

    private static void WhileLoop() {
        const int loopControl = 10;
        int i = 0;

        while (true) {
            Console.Write(i + " ");
            i++;

            if (i >= loopControl) {
                break;
            }
        }
    }

    private static void DoWhileLoop() {
        const int i = 0;

        do {
            Console.Write(i + " ");
        } while (false);
    }

    private static void ForLoop() {
        const int loopControl = 10;

        for (int i = 0; i < loopControl; i++) {
            Console.Write(i + " ");
        }
    }
}