using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MVVM_BasketballRoster.Model;

namespace MVVM_BasketballRoster.ViewModel;

public class RosterViewModel {
    private Roster _roster;
    private string _teamName;
    public ObservableCollection<PlayerViewModel> Starters { get; set; } = [];
    public ObservableCollection<PlayerViewModel> Bench { get; set; } = [];

    public RosterViewModel(Roster roster) {
        _roster = roster;

        TeamName = _roster.TeamName;
        UpdateRosters();
    }

    public string TeamName {
        get => _teamName;
        set => _teamName = value;
    }

    private void UpdateRosters() {
        IEnumerable<PlayerViewModel> statingPLayers = _roster.Players
            .Where(player => player.Starter)
            .Select(player => new PlayerViewModel(player.Name, player.Number));

        foreach (PlayerViewModel player in statingPLayers) {
            Starters.Add(player);
        }

        IEnumerable<PlayerViewModel> benchPlayers = _roster.Players
            .Where(player => !player.Starter)
            .Select(player => new PlayerViewModel(player.Name, player.Number));

        foreach (PlayerViewModel player in benchPlayers) {
            Bench.Add(player);
        }
    }
}