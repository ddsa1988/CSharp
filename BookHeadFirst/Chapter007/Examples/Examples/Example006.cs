using Examples.Models;

namespace Examples;

public static class Example006 {
    public static void Run() {
        IWorker?[] bees = new IWorker[5];
        bees[0] = new HiveDefender();
        bees[1] = new NectarCollector();
        bees[2] = bees[0] as IWorker;
        bees[3] = bees[1] as NectarCollector;
        bees[4] = bees[0];

        for (int i = 0; i < bees.Length; ++i) {
            if (bees[i] is IDefender) {
                Console.WriteLine($"bees[{i}] is IDefender.");
            }

            if (bees[i] is IWorker) {
                Console.WriteLine($"bees[{i}] is IWorker.");
            }

            if (bees[i] is Bee) {
                Console.WriteLine($"bees[{i}] is Bee.");
            }

            Console.WriteLine();
        }
    }
}