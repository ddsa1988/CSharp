using System.Collections.Generic;

namespace MVVM_BasketballRoster.Model;

public class Roster {
    private readonly List<Player> _players = [];
    public string TeamName { get; private set; }
    public IEnumerable<Player> Players => new List<Player>(_players);

    public Roster(string teamName, IEnumerable<Player> players) {
        TeamName = teamName;
        _players.AddRange(players);
    }
}