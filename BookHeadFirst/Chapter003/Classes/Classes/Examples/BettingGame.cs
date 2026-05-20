using Classes.Models;

namespace Classes.Examples;

public static class BettingGame {
    public static void Run() {
        var random = new Random();
        const double odds = 0.75;
        var player = new Guy() { Name = "Player", Cash = 100 };

        Console.WriteLine($"Welcome to the casino. The odds are {odds}.\n");

        while (true) {
            Console.WriteLine($"The {player.Name.ToLower()} has {player.Cash} bucks.");
            Console.Write("How much do you want to bet: ");
            string? userInput = Console.ReadLine();

            bool isAmountValid = int.TryParse(userInput, out int amount) && amount > 0;

            if (!isAmountValid) {
                Console.WriteLine("That is not a valid bet.");
                continue;
            }

            int pot = player.GiveCash(amount) * 2;

            if (pot <= 0) {
                Console.WriteLine($"You do not have enough cash to bet.");
                continue;
            }

            double number = random.NextDouble();

            if (number > odds) {
                player.ReceiveCash(pot);
                Console.WriteLine($"You win {pot}.");
            }
            else {
                Console.WriteLine("Bad luck, you lose.");
            }

            if (player.Cash > 0) {
                continue;
            }

            Console.WriteLine("The house always wins.");

            break;
        }
    }
}