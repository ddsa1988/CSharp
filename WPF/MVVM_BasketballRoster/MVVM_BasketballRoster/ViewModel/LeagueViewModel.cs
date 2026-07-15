using System.Collections.Generic;
using MVVM_BasketballRoster.Model;

namespace MVVM_BasketballRoster.ViewModel;

public class LeagueViewModel {
    public RosterViewModel AnasTeam { get; set; }
    public RosterViewModel TomsTeam { get; set; }

    public LeagueViewModel() {
        var anasRoster = new Roster("The bombers", GetBomberPlayers());
        AnasTeam = new RosterViewModel(anasRoster);

        var tomsRoster = new Roster("The Amazing", GetAmazingPlayers());
        TomsTeam = new RosterViewModel(tomsRoster);
    }

    private static List<Player> GetBomberPlayers() {
        return [
            new Player("Ana", 31, true),
            new Player("Lloyd", 23, true),
            new Player("Kathleen", 6, true),
            new Player("Mike", 0, true),
            new Player("Joe", 42, true),
            new Player("Herb", 32, false),
            new Player("Fingers", 8, false)
        ];
    }

    private static List<Player> GetAmazingPlayers() {
        return [
            new Player("Jimmy", 42, true),
            new Player("Henry", 11, true),
            new Player("Bob", 4, true),
            new Player("Lucinda", 18, true),
            new Player("Kim", 16, true),
            new Player("Bertha", 23, false),
            new Player("Ed", 21, false)
        ];
    }
}