using System.Text.Json;
using HideAndSeek.Enums;
using HideAndSeek.Services;

namespace HideAndSeek.Models;

public class GameController {
    /// <summary>
    /// The player's current location in the house
    /// </summary>
    public Location CurrentLocation { get; private set; }

    /// <summary>
    /// The number of moves the player has made
    /// </summary>
    public int MoveNumber { get; private set; } = 1;

    /// <summary>
    /// List of opponents the player needs to find
    /// </summary>
    public readonly IEnumerable<Opponent> Opponents = new List<Opponent>() {
        new("Joe"),
        new("Bob"),
        new("Ana"),
        new("Owen"),
        new("Jimmy"),
    };

    /// <summary>
    /// Private dictionary of opponents locations for saved game
    /// </summary>
    private readonly Dictionary<string, string> _opponentsLocations = new();

    /// <summary>
    /// Private list of opponents the player has found so far
    /// </summary>
    private readonly List<Opponent> _opponentsFound = [];

    /// <summary>
    /// Returns true if the game is over
    /// </summary>
    public bool IsGameOver => Opponents.Count() == _opponentsFound.Count;

    /// <summary>
    /// Returns true if the player quit the game
    /// </summary>
    public bool QuitGame { get; private set; }

    /// <summary>
    /// A prompt to display to the player
    /// </summary>
    public string Prompt =>
        $"{MoveNumber}: Which direction do you want to go (or type 'check', 'save', 'load', 'quit'): ";

    /// <summary>
    /// Constructor
    /// </summary>
    public GameController() {
        House.ClearHidingPlaces();

        foreach (Opponent opponent in Opponents) {
            _opponentsLocations.Add(opponent.Name, opponent.Hide().Name);
        }

        CurrentLocation = House.Entry;
    }

    /// <summary>
    /// Returns the current status to show to the player
    /// </summary>
    public string Status {
        get {
            string exitsList = Environment.NewLine + string.Join(Environment.NewLine, CurrentLocation.ExitList);
            string status = $"You are in the {CurrentLocation}. You see the following exits:{exitsList}";

            if (CurrentLocation is LocationWithHidingPlace location) {
                status += Environment.NewLine + $"Someone could hide {location.HidingPlace}";
            }

            if (_opponentsFound.Count > 0) {
                status +=
                    Environment.NewLine +
                    $"You have found {_opponentsFound.Count} of {Opponents.Count()} opponents: {string.Join(", ", _opponentsFound)}";
            } else {
                status += Environment.NewLine + "You have not found any opponents";
            }

            return status;
        }
    }

    /// <summary>
    /// Move to the location in a direction
    /// </summary>
    /// <param name="direction">The direction to move</param>
    /// <returns>True if the player can move in that direction, false otherwise</returns>
    public bool Move(Direction direction) {
        if (!CurrentLocation.Exits.TryGetValue(direction, out Location? exit)) return false;

        CurrentLocation = exit;
        return true;
    }

    /// <summary>
    /// Parses input from the player and updates the status
    /// </summary>
    /// <param name="input">Input to parse</param>
    /// <returns>The results of parsing the input</returns>
    public string ParseInput(string input) {
        string userInput = input.ToTitleCase();

        MoveNumber++;

        switch (userInput) {
            case UserChoices.Check: {
                if (CurrentLocation is not LocationWithHidingPlace location) {
                    return $"There is no hiding place in the {CurrentLocation.Name}";
                }

                List<Opponent> hiddenOpponents = location.CheckHidingPlace().ToList();

                if (hiddenOpponents.Count <= 0) return $"Nobody was hiding {location.HidingPlace}";

                _opponentsFound.AddRange(hiddenOpponents);

                string opponentStr = $"opponent{(hiddenOpponents.Count == 1 ? "" : "s")}";

                return $"You found {hiddenOpponents.Count} {opponentStr} hiding {location.HidingPlace}";
            }
            case UserChoices.Save: {
                SavedGame savedGame = new() {
                    PlayerLocation = CurrentLocation.Name,
                    OpponentsLocations = _opponentsLocations,
                    OpponentsFound = _opponentsFound.Select(opponent => opponent.Name).ToList(),
                    MoveNumber = this.MoveNumber,
                };

                string json = JsonSerializer.Serialize(savedGame, JsonWriteOptions);

                return "Saved current game";
            }
            case UserChoices.Load: {
                return "Loaded game";
            }
            case UserChoices.Quit: {
                QuitGame = true;
                return "Exiting the game";
            }
        }

        if (!Enum.TryParse(userInput, out Direction direction)) {
            return "That's not a valid direction";
        }

        if (!CurrentLocation.Exits.ContainsKey(direction)) {
            return "There's no exit in that direction";
        }

        Move(direction);
        return $"Moving {direction.ToString()}";
    }

    private static readonly JsonSerializerOptions JsonWriteOptions = new() {
        WriteIndented = true
    };
}