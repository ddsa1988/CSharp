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
            return $"You are in the {CurrentLocation}. You see the following exits:{exitsList}";
        }
    }

    /// <summary>
    /// A prompt to display to the player
    /// </summary>
    public static string Prompt => "Which direction do you want to go: ";

    public GameController() {
        CurrentLocation = House.Entry;
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
        bool isInputValid = Enum.TryParse(input, out Direction direction);

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