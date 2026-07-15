using System;
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

    private IEnumerable<Player> GetBomberPlayers() {
        return new List<Player> {
            new("Ana", 31, true),
            new("Lloyd", 23, true),
            new("Kathleen", 6, true),
            new("Mike", 0, true),
            new("Joe", 42, true),
            new("Herb", 32, false),
            new("Fingers", 8, false),
        };
    }

    private IEnumerable<Player> GetAmazingPlayers() {
        return new List<Player> {
            new("Jimmy", 42, true),
            new("Henry", 11, true),
            new("Bob", 4, true),
            new("Lucinda", 18, true),
            new("Kim", 16, true),
            new("Bertha", 23, false),
            new("Ed", 21, false),
        };
    }
}