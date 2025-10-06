using GoFish.Models;

namespace GoFish.Services;

public class GameState {
    public readonly IEnumerable<Player> Players;
    public readonly IEnumerable<Player> Opponents;
    public readonly Player HumanPlayer;
    public readonly Deck Stock;
    public bool IsGameOver { get; private set; }

    /// <summary>
    /// Constructor creates the players and deals their first hands
    /// </summary>
    /// <param name="humanPlayerName">Name of the human player</param>
    /// <param name="opponentNames">Names of the computer players</param>
    /// <param name="stock">Shuffled stock of cards to deal from</param>
    public GameState(string humanPlayerName, IEnumerable<string> opponentNames, Deck stock) {
        Stock = stock;

        HumanPlayer = new Player(humanPlayerName);
        HumanPlayer.GetNextHand(Stock);

        var opponents = new List<Player>();

        foreach (string name in opponentNames) {
            if (string.IsNullOrEmpty(name)) continue;

            var player = new Player(name);
            player.GetNextHand(Stock);
            opponents.Add(player);
        }

        Opponents = opponents;
        Players = new List<Player>() { HumanPlayer }.Concat(opponents);
    }

    /// <summary>
    /// Gets a random player that doesn't match the current player
    /// </summary>
    /// <param name="currentPlayer">The current player</param>
    /// <returns>A random player that the current player can ask for a card</returns>
    public Player RandomPlayer(Player currentPlayer) => Players
        .Where(player => player.Name != currentPlayer.Name)
        .Skip(Player.Random.Next(0, Players.Count()))
        .First();

    /// <summary>
    /// Makes one player play a round
    /// </summary>
    /// <param name="player">The player asking for a card</param>
    /// <param name="playerToAsk">The player being asked for a card</param>
    /// <param name="valueToAskFor">The value to ask the player for</param>
    /// <param name="stock">The stock to draw cards from</param>
    /// <returns>A message that describes what just happened</returns>
    public string PlayRound(Player player, Player playerToAsk, Values valueToAskFor, Deck stock) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Checks for a winner by seeing if any players have any cards left, sets GameOver
    /// if the game is over and there's a winner
    /// </summary>
    /// <returns>A string with the winners, an empty string if there are no winners</returns>
    public string CheckForWinner() {
        throw new NotImplementedException();
    }
}