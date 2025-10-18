using GoFishBlazor.Models;

namespace GoFishBlazor.Services;

public class Game {
    private readonly GameController _game;

    public Game(string humanPlayerName, IEnumerable<string> computerPlayerNames) {
        _game = new GameController(humanPlayerName, computerPlayerNames);
    }

    public int PlayerCardCount => _game.HumanPlayer.Hand.Count();
    public int OpponentCount => _game.Opponents.Count();

    public string GameProgress => _game.Status;

    public string PlayerCardName(int index) {
        if (index < 0 || index >= _game.HumanPlayer.Hand.Count()) return string.Empty;

        return _game.HumanPlayer.Hand.ElementAt(index).ToString();
    }

    public string PlayerCardValue(int index) {
        if (index < 0 || index >= _game.HumanPlayer.Hand.Count()) return string.Empty;

        return _game.HumanPlayer.Hand.ElementAt(index).Value.ToString();
    }

    public string OpponentName(int index) {
        if (index < 0 || index >= _game.Opponents.Count()) return string.Empty;

        return _game.Opponents.ElementAt(index).ToString();
    }

    public void PlayerAskForCard(int indexCard, int indexOpponent) {
        if (indexCard < 0 || indexCard >= _game.HumanPlayer.Hand.Count()) return;
        if (indexOpponent < 0 || indexOpponent >= _game.Opponents.Count()) return;

        Card card = _game.HumanPlayer.Hand.ElementAt(indexCard);
        Player opponent = _game.Opponents.ElementAt(indexOpponent);

        _game.NextRound(opponent, card.Value);
    }
}