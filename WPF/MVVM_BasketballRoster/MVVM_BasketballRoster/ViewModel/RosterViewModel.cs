using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MVVM_BasketballRoster.Model;

namespace MVVM_BasketballRoster.ViewModel;

public class RosterViewModel {
    private readonly Roster? _roster;
    public ObservableCollection<PlayerViewModel> Starters { get; set; } = [];
    public ObservableCollection<PlayerViewModel> Bench { get; set; } = [];
    public string TeamName { get; set; } = string.Empty;

    public RosterViewModel() { }

    public RosterViewModel(Roster roster) {
        _roster = roster;

        TeamName = _roster.TeamName;
        UpdateRosters();
    }

    private void UpdateRosters() {
        if (_roster == null) return;

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