using HideAndSeek.Models;

namespace HideAndSeek;

public static class Program {
    public static void Main() {
        while (true) {
            var gameController = new GameController();

            while (!gameController.GameOver) {
                Console.WriteLine(gameController.Status + Environment.NewLine);
                Console.Write(gameController.Prompt);
                Console.WriteLine(gameController.ParseInput(Console.ReadLine() ?? string.Empty));
            }

            Console.WriteLine($"You won the game in {gameController.MoveNumber} moves!");
            Console.WriteLine("Press P to play again, any other key to quit.");
            if (!Console.ReadKey(true).KeyChar.ToString()
                    .Equals("P", StringComparison.CurrentCultureIgnoreCase)) return;
        }
    }
}