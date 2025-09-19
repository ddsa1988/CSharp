using Examples.Exercises.Models;

namespace Examples.Exercises;

public static class Exercise001 {
    public static void Run() {
        var lumberjacks = new Queue<Lumberjack>();
        var random = new Random();
        string? name;

        Console.Write("First lumberjack's name: ");

        while (!string.IsNullOrEmpty(name = Console.ReadLine())) {
            Console.Write("Number of flapjacks: ");

            if (int.TryParse(Console.ReadLine(), out int number)) {
                var lumberjack = new Lumberjack(name);

                for (int i = 0; i < number; i++) {
                    lumberjack.TakeFlapjack((Flapjack)random.Next(4));
                }

                lumberjacks.Enqueue(lumberjack);
            }

            Console.Write("Next lumberjack's name (blank to end): ");
        }

        while (lumberjacks.Count > 0) {
            Console.WriteLine();
            Lumberjack lumberjack = lumberjacks.Dequeue();
            lumberjack.EatFlapjack();
        }
    }
}