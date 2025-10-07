using GoFish.Models;

namespace GoFish.Services;

public class GameController {
    private GameState _gameState;
    public static Random Random = new();
    public string Status { get; private set; }

    public bool IsGameOver => _gameState.IsGameOver;
    public Player HumanPlayer => _gameState.HumanPlayer;
    public IEnumerable<Player> Opponents => _gameState.Opponents;

    /// <summary>
    /// Constructs a new GameController
    /// </summary>
    /// <param name="humanPlayerName">Name of the human player</param>
    /// <param name="computerPlayerNames">Names of the computer players</param>
    public GameController(string humanPlayerName, IEnumerable<string> computerPlayerNames) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Plays the next round, ending the game if everyone ran out of cards
    /// </summary>
    /// <param name="playerToAsk">Which player the human is asking for a card</param>
    /// <param name="valueToAskFor">The value of the card the human is asking for</param>
    public void NextRound(Player playerToAsk, Values valueToAskFor) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// All the computer players that have cards play the next round. If the human is
    /// out of cards, then the deck is depleted and they play out the rest of the game.
    /// </summary>
    private void ComputerPlayersPlayNextRound() {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Starts a new game with the same player names
    /// </summary>
    public void NewGame() {
        throw new NotImplementedException();
    }
}