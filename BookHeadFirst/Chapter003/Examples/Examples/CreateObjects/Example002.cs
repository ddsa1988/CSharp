using Examples.Models;

namespace Examples.CreateObjects;

public static class Example002 {
    public static void Run() {
        const float odds = 0.75F;
        var player = new Player() { Name = "The player", Cash = 100 };

        Console.WriteLine($"Welcome to the casino. The odds are {odds:F2}");

        while (player.Cash > 0) {
            player.WriteMyInfo();

            float guess = GetRandomNumber();
            int betAmount = GetBetAmount();

            if (betAmount > player.Cash) {
                Console.WriteLine("You don't have enough cash!");
                continue;
            }

            if (guess > odds) {
                int pot = betAmount * 2;
                player.ReceiveCash(pot);
                Console.WriteLine($"You won {pot}!");
            } else {
                player.GiveCash(betAmount);
                Console.WriteLine($"Bad luck! You lost {betAmount}!");
            }
        }

        Console.WriteLine("The house always wins!");
    }

    private static float GetRandomNumber() {
        var random = new Random();
        return (float)random.NextDouble();
    }

    private static int GetBetAmount() {
        int betAmount;

        while (true) {
            Console.Write("How much would you like to bet: ");
            string? input = Console.ReadLine();

            bool isInputValid = int.TryParse(input, out betAmount) && betAmount > 0;

            if (!isInputValid) {
                Console.WriteLine("That is not a valid number.");
                continue;
            }

            break;
        }

        return betAmount;
    }
}