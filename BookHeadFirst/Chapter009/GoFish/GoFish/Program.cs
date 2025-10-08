using GoFish.Models;
using GoFish.Services;

namespace GoFish;

public static class Program {
    public static void Main(string[] args) {
        List<string> computerNames = ["Computer #1", "Computer #2"];
        _gameController = new GameController("Diego", computerNames);

        PromptForAnOpponent();
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
        throw new NotImplementedException();
    }
}