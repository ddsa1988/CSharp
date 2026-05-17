namespace StatementsAndLoops.Examples;

public static class PrintMatrix {
    public static void Run() {
        for (int row = 0; row < 5; row++) {
            for (int column = 0; column < 5; column++) {
                Console.Write($"{row}{column} ");
            }

            Console.WriteLine();
        }
    }
}