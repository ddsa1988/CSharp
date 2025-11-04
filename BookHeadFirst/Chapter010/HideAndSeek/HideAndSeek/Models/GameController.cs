using HideAndSeek.Enums;

namespace HideAndSeek.Models;

public class GameController {
    /// <summary>
    /// The player's current location in the house
    /// </summary>
    public Location CurrentLocation { get; private set; }

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

            if (_foundOpponents.Count > 0) {
                status +=
                    Environment.NewLine +
                    $"You have found {_foundOpponents.Count} of {Opponents.Count()} opponents: {string.Join(", ", _foundOpponents)}";
            } else {
                status += Environment.NewLine + "You have not found any opponents";
            }

            return status;
        }
    }

    /// <summary>
    /// The number of moves the player has made
    /// </summary>
    public int MoveNumber { get; private set; } = 1;

    /// <summary>
    /// Private list of opponents the player needs to find
    /// </summary>
    public readonly IEnumerable<Opponent> Opponents = new List<Opponent>() {
        new Opponent("Joe"),
        new Opponent("Bob"),
        new Opponent("Ana"),
        new Opponent("Owen"),
        new Opponent("Jimmy"),
    };

    /// <summary>
    /// Private list of opponents the player has found so far
    /// </summary>
    private readonly List<Opponent> _foundOpponents = [];

    public GameController() {
        House.ClearHidingPlaces();

        foreach (Opponent opponent in Opponents) {
            opponent.Hide();
        }

        CurrentLocation = House.Entry;
    }

    /// <summary>
    /// Returns true if the game is over
    /// </summary>
    public bool GameOver => Opponents.Count() == _foundOpponents.Count;

    /// <summary>
    /// A prompt to display to the player
    /// </summary>
    public string Prompt => $"{MoveNumber}: Which direction do you want to go (or type 'check'): ";

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
        bool isInputCheck = input.Equals("check", StringComparison.CurrentCultureIgnoreCase);
        bool isInputValid = Enum.TryParse(input, out Direction direction);

        MoveNumber++;

        if (isInputCheck) {
            if (CurrentLocation is not LocationWithHidingPlace location) {
                return $"There is no hiding place in the {CurrentLocation.Name}";
            }

            List<Opponent> hiddenOpponents = location.CheckHidingPlace().ToList();

            if (hiddenOpponents.Count <= 0) return $"Nobody was hiding {location.HidingPlace}";

            _foundOpponents.AddRange(hiddenOpponents);

            string opponentStr = $"opponent{(hiddenOpponents.Count == 1 ? "" : "s")}";

            return $"You found {hiddenOpponents.Count} {opponentStr} hiding {location.HidingPlace}";
        }

        if (!isInputValid) {
            return "That's not a valid direction";
        }

        if (!CurrentLocation.Exits.ContainsKey(direction)) {
            return "There's no exit in that direction";
        }

        Move(direction);
        return $"Moving {direction.ToString()}";
    }
}