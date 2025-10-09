using GoFish.Models;
using GoFish.Services;

namespace GoFish;

public static class Program {
    /// <summary>
    /// The GameController to manage the game
    /// </summary>
    private static GameController? _gameController;

    /// <summary>
    /// The Mian method is the entry point of the application
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args) {
        const int opponentCountMin = 1;
        const int opponentCountMax = 5;
        string? humanName = string.Empty;
        int opponentCount = 0;

        while (string.IsNullOrWhiteSpace(humanName)) {
            Console.Write("Enter your name: ");
            humanName = Console.ReadLine();
        }

        while (opponentCount == 0) {
            Console.Write($"Enter the number of computer opponents ({opponentCountMin} to {opponentCountMax}): ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out int number) && number >= opponentCountMin &&
                                 number <= opponentCountMax;

            if (!isNumberValid) continue;

            opponentCount = number;
        }

        Console.WriteLine($"{Environment.NewLine}Welcome to the game, {humanName}!");

        IEnumerable<string> computerPlayerNames = Enumerable.Range(1, opponentCount).Select(i => $"Computer #{i}");
        _gameController = new GameController(humanName, computerPlayerNames);

        Console.WriteLine(_gameController.Status + Environment.NewLine);

        while (!_gameController.IsGameOver) {
            while (!_gameController.IsGameOver) {
                Console.WriteLine("Your hand: ");
                foreach (Card card in _gameController.HumanPlayer.Hand.OrderBy(card => card.Value)
                             .ThenBy(card => card.Suit)) {
                    Console.WriteLine(card);
                }

                Values value = PromptForAValue(_gameController);

                Player player = PromptForAnOpponent(_gameController);

                _gameController.NextRound(player, value);

                Console.WriteLine(_gameController.Status);
            }

            Console.WriteLine("Press N for a new game, any other key to quit.");

            if (Console.ReadKey(true).KeyChar.ToString().Equals("N", StringComparison.CurrentCultureIgnoreCase)) {
                _gameController.NewGame();
            }
        }
    }

    /// <summary>
    /// Prompt the human player for a card value
    /// in their hand
    /// </summary>
    /// <returns>The value to ask for</returns>
    private static Values PromptForAValue(GameController gameController) {
        IEnumerable<Values> handValues = gameController.HumanPlayer.Hand.Select(card => card.Value).ToList();

        while (true) {
            Console.Write("What card value do you want to ask for? ");
            string? userInput = Console.ReadLine();

            bool isValueValid = Enum.TryParse(userInput, true, out Values value) && handValues.Contains(value);

            if (!isValueValid) continue;

            return value;
        }
    }

    /// <summary>
    /// Prompt the human player for an opponent
    /// to ask for a card
    /// </summary>
    /// <returns>The opponent to ask</returns>
    private static Player PromptForAnOpponent(GameController gameController) {
        IEnumerable<Player> opponents = gameController.Opponents.ToList();

        for (int i = 0; i < opponents.Count(); i++) {
            Console.WriteLine($"{i + 1}. {opponents.ElementAt(i)}");
        }

        while (true) {
            Console.Write("Who do you want to ask for a card? ");
            string? userInput = Console.ReadLine();

            bool isPlayerValid = int.TryParse(userInput, out int index) && index > 0 &&
                                 index <= opponents.Count();

            if (!isPlayerValid) continue;

            return opponents.ElementAt(index - 1);
        }
    }
}