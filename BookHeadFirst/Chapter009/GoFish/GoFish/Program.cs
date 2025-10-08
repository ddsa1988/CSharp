using GoFish.Models;
using GoFish.Services;

namespace GoFish;

public static class Program {
    public static void Main(string[] args) {
        List<string> computerNames = ["Computer #1", "Computer #2"];
        _gameController = new GameController("Diego", computerNames);
    }

    /// <summary>
    /// The GameController to manage the game
    /// </summary>
    private static GameController _gameController;

    /// <summary>
    /// Prompt the human player for a card value
    /// in their hand
    /// </summary>
    /// <returns>The value to ask for</returns>
    private static Values PromptForAValue() {
        IEnumerable<Values> handValues = _gameController.HumanPlayer.Hand.Select(card => card.Value).ToList();

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
    private static Player PromptForAnOpponent() {
        IEnumerable<Player> opponents = _gameController.Opponents.ToList();

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